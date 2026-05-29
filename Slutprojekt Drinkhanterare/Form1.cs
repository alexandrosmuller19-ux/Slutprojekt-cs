using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using drinks_info.Models;

namespace drinks_info
{
    public partial class Form1 : Form
    {
        //service för att hämta drink-data från API
        private DrinksService drinksService;
        //applikationens tillstånd som hanterar kategorier, drinkar och mappningar
        private AppState appState;

   
        private System.Drawing.Color accentColor = System.Drawing.Color.FromArgb(0, 120, 215);     
        private System.Drawing.Color successColor = System.Drawing.Color.FromArgb(16, 124, 16);    
        private System.Drawing.Color warningColor = System.Drawing.Color.FromArgb(255, 192, 0);   
        private System.Drawing.Color errorColor = System.Drawing.Color.FromArgb(208, 0, 0);      

        public Form1()
        {
            InitializeComponent();
            //använd ServiceFactory för att skapa tjänster istället för att newa direkt
            drinksService = ServiceFactory.CreateDrinksService();
            appState = ServiceFactory.CreateAppState();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //ladda kategorier direkt
            LoadCategoriesAsync();
            //ladda anpassade drinkar
            RefreshCustomDrinksDisplay();
        }

        //uppdaterar statuslabeln med text och färg baserad på status
        private void UpdateStatusLabel(string message, System.Drawing.Color color)
        {
            statusLabel.Text = message;
            statusLabel.ForeColor = color;
            Application.DoEvents();
        }

        private void LoadCategoriesAsync()
        {
            try
            {
                //visa status medan kategorier laddas
                UpdateStatusLabel("Loading categories...", accentColor);

                var categories = drinksService.GetCategories();
                //lagra kategorierna i appState istället för lokalt
                appState.Categories = categories;

                categoriesListBox.Items.Clear();
                foreach (var category in categories)
                {
                    categoriesListBox.Items.Add(category.strCategory);
                }

                //välj automatiskt första kategorin för snabb åtkomst
                if (categoriesListBox.Items.Count > 0)
                {
                    categoriesListBox.SelectedIndex = 0;
                }

                UpdateStatusLabel("Ready", successColor);
            }
            catch (Exception ex)
            {
                UpdateStatusLabel("Error loading categories", errorColor);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesListBox.SelectedIndex >= 0)
            {
                string selectedCategory = categoriesListBox.SelectedItem.ToString();
                //ladda drinkar för vald kategori
                LoadDrinksForCategory(selectedCategory);
            }
        }

        private void LoadDrinksForCategory(string category)
        {
            try
            {
                //uppdatera status och ladda drink-listan
                UpdateStatusLabel("Loading drinks...", accentColor);

                var drinks = drinksService.GetDrinksByCategory(category);
                //använd appState för att uppdatera drinkar och mappningen
                appState.SetCurrentDrinks(drinks);

                drinksListBox.Items.Clear();

                foreach (var drink in appState.CurrentDrinks)
                {
                    drinksListBox.Items.Add(drink.strDrink);
                }

                //välj första drink automatiskt och visa detaljer
                if (drinksListBox.Items.Count > 0)
                {
                    drinksListBox.SelectedIndex = 0;
                    //automatiskt visa detaljer för första drinken
                    string firstDrinkName = drinksListBox.Items[0].ToString();
                    if (appState.TryGetDrinkId(firstDrinkName, out string drinkId))
                    {
                        LoadDrinkDetails(drinkId, firstDrinkName);
                    }
                }
                else
                {
                    drinkDetailsTextBox.Clear();
                    drinkImagePictureBox.Image = null;
                }

                UpdateStatusLabel("Ready", successColor);
            }
            catch (Exception ex)
            {
                UpdateStatusLabel("Error loading drinks", errorColor);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrinksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //när användaren byter selection, visa detaljer direkt
            if (drinksListBox.SelectedIndex >= 0)
            {
                string selectedDrinkName = drinksListBox.SelectedItem.ToString();
                //använd appState för att hämta drink-ID
                if (appState.TryGetDrinkId(selectedDrinkName, out string drinkId))
                {
                    LoadDrinkDetails(drinkId, selectedDrinkName);
                }
            }
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (drinksListBox.SelectedIndex >= 0)
            {
                string selectedDrinkName = drinksListBox.SelectedItem.ToString();
                //använd appState för att hämta drink-ID
                if (appState.TryGetDrinkId(selectedDrinkName, out string drinkId))
                {
                    //manuell knapp för att uppdatera detaljer i fall det behövs, annars laddas detaljer automatiskt vid selection
                    LoadDrinkDetails(drinkId, selectedDrinkName);
                }
            }
            else
            {
                MessageBox.Show("Please select a drink first", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadDrinkDetails(string drinkId, string drinkName)
        {
            try
            {
                UpdateStatusLabel("Loading details...", accentColor);

                drinksService.GetDrinkDetails(drinkId, OnDrinkDetailsLoaded, OnDrinkImageLoaded);

                UpdateStatusLabel("Ready", successColor);
            }
            catch (Exception ex)
            {
                UpdateStatusLabel("Error loading details", errorColor);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDrinkDetailsLoaded(string details)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(OnDrinkDetailsLoaded), details);
            }
            else
            {
                try { 
                //visa detaljer i textfältet
                drinkDetailsTextBox.Text = details;
                drinkDetailsTextBox.Select(0, 0);
                }
                
                catch (Exception ex)
                {
                    //detaljvisning misslyckades, ignorerar för att undvika krasch
                }
            }
        }

        private void OnDrinkImageLoaded(string imageUrl)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(OnDrinkImageLoaded), imageUrl);
            }
            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        //ladda bilden i picturebox
                        drinkImagePictureBox.Load(imageUrl);
                    }
                }
                catch (Exception ex)
                {
                    //bildinläsning misslyckades, ignorerar för att undvika krasch
                }
            }
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        //öppnar formuläret för att lägga till en anpassad drink
        private void AddCustomDrinkButton_Click(object sender, EventArgs e)
        {
            var form = new AddCustomDrinkForm();
            if (form.ShowDialog() == DialogResult.OK && form.CreatedDrink != null)
            {
                appState.AddCustomDrink(form.CreatedDrink);
                UpdateStatusLabel("Custom drink added successfully!", successColor);
                RefreshCustomDrinksDisplay();
            }
        }

        //visar anpassade drinkar i UI
        private void RefreshCustomDrinksDisplay()
        {
            customDrinksListBox.Items.Clear();
            foreach (var drink in appState.CustomDrinks)
            {
                customDrinksListBox.Items.Add(drink.strDrink);
            }
        }

        //hanterar när användaren väljer en anpassad drink
        private void CustomDrinksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customDrinksListBox.SelectedIndex >= 0)
            {
                string selectedDrinkName = customDrinksListBox.SelectedItem.ToString();
                var selectedDrink = appState.CustomDrinks.FirstOrDefault(d => d.strDrink == selectedDrinkName);

                if (selectedDrink != null)
                {
                    DisplayCustomDrinkDetails(selectedDrink);
                    drinksListBox.SelectedIndex = -1; // Avmarkera API-drinkar
                }
            }
        }

        //visar detaljer för en anpassad drink
        private void DisplayCustomDrinkDetails(CustomDrink drink)
        {
            var details = new System.Text.StringBuilder();
            details.AppendLine($"Drink: {drink.strDrink}");
            details.AppendLine($"Category: {drink.Category}");
            details.AppendLine($"Glass: {drink.Glass}");
            details.AppendLine($"Alcoholic: {drink.Alcoholic}");
            details.AppendLine($"Created: {drink.CreatedDate:yyyy-MM-dd HH:mm}");
            details.AppendLine("\nIngredients: ");

            foreach (var ingredient in drink.Ingredients)
            {
                details.AppendLine($"  • {ingredient.Name} - {ingredient.Measure}");
            }

            details.AppendLine($"\nInstructions: \n{drink.Instructions}");

            drinkDetailsTextBox.Text = details.ToString();
            drinkDetailsTextBox.Select(0, 0);
            drinkImagePictureBox.Image = null;
        }

        //öppnar formuläret för att redigera en anpassad drink
        private void EditCustomDrinkButton_Click(object sender, EventArgs e)
        {
            if (customDrinksListBox.SelectedIndex >= 0)
            {
                string selectedDrinkName = customDrinksListBox.SelectedItem.ToString();
                var selectedDrink = appState.CustomDrinks.FirstOrDefault(d => d.strDrink == selectedDrinkName);

                if (selectedDrink != null)
                {
                    var form = new AddCustomDrinkForm(selectedDrink);
                    if (form.ShowDialog() == DialogResult.OK && form.CreatedDrink != null)
                    {
                        appState.AddCustomDrink(form.CreatedDrink);
                        UpdateStatusLabel("Custom drink updated successfully!", successColor);
                        RefreshCustomDrinksDisplay();
                        DisplayCustomDrinkDetails(form.CreatedDrink);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a custom drink to edit", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //tar bort en anpassad drink
        private void DeleteCustomDrinkButton_Click(object sender, EventArgs e)
        {
            if (customDrinksListBox.SelectedIndex >= 0)
            {
                string selectedDrinkName = customDrinksListBox.SelectedItem.ToString();
                var selectedDrink = appState.CustomDrinks.FirstOrDefault(d => d.strDrink == selectedDrinkName);

                if (selectedDrink != null)
                {
                    var result = MessageBox.Show($"Are you sure you want to delete '{selectedDrink.strDrink}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        appState.RemoveCustomDrink(selectedDrink.idDrink);
                        UpdateStatusLabel("Custom drink deleted successfully!", successColor);
                        RefreshCustomDrinksDisplay();
                        drinkDetailsTextBox.Clear();
                        drinkImagePictureBox.Image = null;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a custom drink to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void customDrinksPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customDrinksLabel_Click(object sender, EventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customDrinksButtonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customDrinksPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void customDrinksLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrinkImagePictureBox_Resize(object sender, EventArgs e)
        {
            
        }

        private void RightPanel_Resize(object sender, EventArgs e)
        {
            
        }
    }
}