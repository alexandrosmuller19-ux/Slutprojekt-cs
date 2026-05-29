using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using drinks_info.Models;

namespace drinks_info
{
    public partial class AddCustomDrinkForm : Form
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private bool isEditing = false;
        private CustomDrink editingDrink = null;
        private DrinksService drinksService;

        public CustomDrink CreatedDrink { get; set; }

        public AddCustomDrinkForm()
        {
            InitializeComponent();
            drinksService = ServiceFactory.CreateDrinksService();
            ApplyDarkMode();
            LoadCategories();
        }

        //constructor för att öppna formuläret i redigeringsläge med en befintlig drink
        public AddCustomDrinkForm(CustomDrink drinkToEdit) : this()
        {
            isEditing = true;
            editingDrink = drinkToEdit;
            LoadDrinkForEditing(drinkToEdit);
        }

        private void LoadCategories()
        {
            try
            {
                var categories = drinksService.GetCategories();
                categoryComboBox.Items.Clear();

                foreach (var category in categories)
                {
                    categoryComboBox.Items.Add(category.strCategory);
                }

                //sätter första kategorin som standardval om det finns några kategorier
                if (categoryComboBox.Items.Count > 0)
                {
                    categoryComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                //fallback till hårdkodade kategorier om API-anropet misslyckas
                categoryComboBox.Items.Clear();
                categoryComboBox.Items.AddRange(new object[] { "Cocktail", "Ordinary Drink", "Punch", "Shake", "Other" });
                categoryComboBox.SelectedIndex = 0;
            }
        }

        private void ApplyDarkMode()
        {
            this.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            this.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            try { 
                foreach (Control control in GetAllControls(this))
                {
                    if (control is Label || control is GroupBox)
                    {
                        control.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
                        control.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
                    }
                    else if (control is TextBox)
                    {
                        control.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                        control.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
                    }
                    else if (control is ComboBox)
                    {
                        control.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                        control.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
                    }
                    else if (control is ListBox)
                    {
                        control.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
                        control.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine($"Error applying dark mode: {ex.Message}");
            }
        }

        private List<Control> GetAllControls(Control container)
        {
            List<Control> all = new List<Control>();
            foreach (Control control in container.Controls)
            {
                all.Add(control);
                all.AddRange(GetAllControls(control));
            }
            return all;
        }

        private void LoadDrinkForEditing(CustomDrink drink)
        {
            drinkNameTextBox.Text = drink.strDrink;

            //hittar och väljer rätt kategori i comboboxen baserat på drinkens kategori
            int categoryIndex = categoryComboBox.Items.IndexOf(drink.Category);
            if (categoryIndex >= 0)
            {
                categoryComboBox.SelectedIndex = categoryIndex;
            }
            else if (categoryComboBox.Items.Count > 0)
            {
                categoryComboBox.SelectedIndex = 0;
            }

            instructionsTextBox.Text = drink.Instructions;
            glassTypeTextBox.Text = drink.Glass;

            //hittar och väljer rätt alkoholhaltighet i comboboxen baserat på drinkens alkoholhaltighet
            int alcoholicIndex = alcoholicComboBox.Items.IndexOf(drink.Alcoholic);
            if (alcoholicIndex >= 0)
            {
                alcoholicComboBox.SelectedIndex = alcoholicIndex;
            }
            else
            {
                alcoholicComboBox.SelectedIndex = 0;
            }

            ingredients.Clear();
            ingredients.AddRange(drink.Ingredients ?? new List<Ingredient>());
            RefreshIngredientsListBox();

            submitButton.Text = "Update Drink";
            this.Text = "Edit Custom Drink";
        }

        private void RefreshIngredientsListBox()
        {
            ingredientsListBox.Items.Clear();
            foreach (var ingredient in ingredients)
            {
                ingredientsListBox.Items.Add($"{ingredient.Name} - {ingredient.Measure}");
            }
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            string ingredientName = ingredientNameTextBox.Text.Trim();
            string ingredientMeasure = ingredientMeasureTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(ingredientName) || string.IsNullOrWhiteSpace(ingredientMeasure))
            {
                MessageBox.Show("Please enter both ingredient name and measure", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ingredients.Add(new Ingredient { Name = ingredientName, Measure = ingredientMeasure });
            RefreshIngredientsListBox();

            ingredientNameTextBox.Clear();
            ingredientMeasureTextBox.Clear();
            ingredientNameTextBox.Focus();
        }

        private void RemoveIngredientButton_Click(object sender, EventArgs e)
        {
            if (ingredientsListBox.SelectedIndex >= 0)
            {
                ingredients.RemoveAt(ingredientsListBox.SelectedIndex);
                RefreshIngredientsListBox();
            }
            else
            {
                MessageBox.Show("Please select an ingredient to remove", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            CustomDrink drink = isEditing ? editingDrink : new CustomDrink();

            drink.strDrink = drinkNameTextBox.Text.Trim();
            drink.Category = categoryComboBox.SelectedItem?.ToString() ?? "Cocktail";
            drink.Instructions = instructionsTextBox.Text.Trim();
            drink.Glass = glassTypeTextBox.Text.Trim();
            drink.Alcoholic = alcoholicComboBox.SelectedItem?.ToString() ?? "Yes";
            drink.Ingredients = new List<Ingredient>(ingredients);
            drink.CreatedDate = isEditing ? editingDrink.CreatedDate : DateTime.Now;

            //genererar ett unikt ID för den nya drinken om en befintlig drink inte redigeras
            if (!isEditing)
            {
                drink.idDrink = "custom_" + Guid.NewGuid().ToString().Substring(0, 8);
            }

            CreatedDrink = drink;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text))
            {
                MessageBox.Show("Please enter a drink name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ingredients.Count == 0)
            {
                MessageBox.Show("Please add at least one ingredient", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(instructionsTextBox.Text))
            {
                MessageBox.Show("Please enter instructions", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(glassTypeTextBox.Text))
            {
                MessageBox.Show("Please enter glass type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
