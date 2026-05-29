namespace drinks_info
{
    partial class AddCustomDrinkForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainPanel = new System.Windows.Forms.Panel();
            drinkNameLabel = new System.Windows.Forms.Label();
            drinkNameTextBox = new System.Windows.Forms.TextBox();
            categoryLabel = new System.Windows.Forms.Label();
            categoryComboBox = new System.Windows.Forms.ComboBox();
            glassTypeLabel = new System.Windows.Forms.Label();
            glassTypeTextBox = new System.Windows.Forms.TextBox();
            alcoholicLabel = new System.Windows.Forms.Label();
            alcoholicComboBox = new System.Windows.Forms.ComboBox();
            instructionsLabel = new System.Windows.Forms.Label();
            instructionsTextBox = new System.Windows.Forms.TextBox();
            ingredientsGroupBox = new System.Windows.Forms.GroupBox();
            ingredientNameLabel = new System.Windows.Forms.Label();
            ingredientNameTextBox = new System.Windows.Forms.TextBox();
            ingredientMeasureLabel = new System.Windows.Forms.Label();
            ingredientMeasureTextBox = new System.Windows.Forms.TextBox();
            addIngredientButton = new System.Windows.Forms.Button();
            ingredientsListBox = new System.Windows.Forms.ListBox();
            removeIngredientButton = new System.Windows.Forms.Button();
            submitButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            mainPanel.SuspendLayout();
            ingredientsGroupBox.SuspendLayout();
            SuspendLayout();

            // mainPanel
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            mainPanel.Controls.Add(submitButton);
            mainPanel.Controls.Add(cancelButton);
            mainPanel.Controls.Add(ingredientsGroupBox);
            mainPanel.Controls.Add(instructionsLabel);
            mainPanel.Controls.Add(instructionsTextBox);
            mainPanel.Controls.Add(alcoholicLabel);
            mainPanel.Controls.Add(alcoholicComboBox);
            mainPanel.Controls.Add(glassTypeLabel);
            mainPanel.Controls.Add(glassTypeTextBox);
            mainPanel.Controls.Add(categoryLabel);
            mainPanel.Controls.Add(categoryComboBox);
            mainPanel.Controls.Add(drinkNameLabel);
            mainPanel.Controls.Add(drinkNameTextBox);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new System.Windows.Forms.Padding(20);
            mainPanel.Size = new System.Drawing.Size(600, 800);
            mainPanel.TabIndex = 0;

            // drinkNameLabel
            drinkNameLabel.AutoSize = true;
            drinkNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            drinkNameLabel.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            drinkNameLabel.Location = new System.Drawing.Point(20, 20);
            drinkNameLabel.Name = "drinkNameLabel";
            drinkNameLabel.Size = new System.Drawing.Size(93, 20);
            drinkNameLabel.TabIndex = 0;
            drinkNameLabel.Text = "Drink Name";

            // drinkNameTextBox
            drinkNameTextBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            drinkNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            drinkNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            drinkNameTextBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            drinkNameTextBox.Location = new System.Drawing.Point(20, 45);
            drinkNameTextBox.Name = "drinkNameTextBox";
            drinkNameTextBox.Size = new System.Drawing.Size(540, 25);
            drinkNameTextBox.TabIndex = 1;

            // categoryLabel
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            categoryLabel.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            categoryLabel.Location = new System.Drawing.Point(20, 80);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(71, 20);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category";

            // categoryComboBox
            categoryComboBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            categoryComboBox.Items.AddRange(new object[] { "Cocktail", "Ordinary Drink", "Punch", "Shake", "Other" });
            categoryComboBox.Location = new System.Drawing.Point(20, 105);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new System.Drawing.Size(540, 25);
            categoryComboBox.TabIndex = 3;
            categoryComboBox.SelectedIndex = 0;

            // glassTypeLabel
            glassTypeLabel.AutoSize = true;
            glassTypeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            glassTypeLabel.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            glassTypeLabel.Location = new System.Drawing.Point(20, 140);
            glassTypeLabel.Name = "glassTypeLabel";
            glassTypeLabel.Size = new System.Drawing.Size(78, 20);
            glassTypeLabel.TabIndex = 4;
            glassTypeLabel.Text = "Glass Type";

            // glassTypeTextBox
            glassTypeTextBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            glassTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            glassTypeTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            glassTypeTextBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            glassTypeTextBox.Location = new System.Drawing.Point(20, 165);
            glassTypeTextBox.Name = "glassTypeTextBox";
            glassTypeTextBox.Size = new System.Drawing.Size(540, 25);
            glassTypeTextBox.TabIndex = 5;

            // alcoholicLabel
            alcoholicLabel.AutoSize = true;
            alcoholicLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            alcoholicLabel.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            alcoholicLabel.Location = new System.Drawing.Point(20, 200);
            alcoholicLabel.Name = "alcoholicLabel";
            alcoholicLabel.Size = new System.Drawing.Size(75, 20);
            alcoholicLabel.TabIndex = 6;
            alcoholicLabel.Text = "Alcoholic";

            // alcoholicComboBox
            alcoholicComboBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            alcoholicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            alcoholicComboBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            alcoholicComboBox.Items.AddRange(new object[] { "Yes", "No" });
            alcoholicComboBox.Location = new System.Drawing.Point(20, 225);
            alcoholicComboBox.Name = "alcoholicComboBox";
            alcoholicComboBox.Size = new System.Drawing.Size(540, 25);
            alcoholicComboBox.TabIndex = 7;
            alcoholicComboBox.SelectedIndex = 0;

            // instructionsLabel
            instructionsLabel.AutoSize = true;
            instructionsLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            instructionsLabel.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            instructionsLabel.Location = new System.Drawing.Point(20, 260);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new System.Drawing.Size(84, 20);
            instructionsLabel.TabIndex = 8;
            instructionsLabel.Text = "Instructions";

            // instructionsTextBox
            instructionsTextBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            instructionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            instructionsTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            instructionsTextBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            instructionsTextBox.Location = new System.Drawing.Point(20, 285);
            instructionsTextBox.Multiline = true;
            instructionsTextBox.Name = "instructionsTextBox";
            instructionsTextBox.Size = new System.Drawing.Size(540, 80);
            instructionsTextBox.TabIndex = 9;

            // ingredientsGroupBox
            ingredientsGroupBox.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ingredientsGroupBox.Controls.Add(ingredientNameLabel);
            ingredientsGroupBox.Controls.Add(ingredientNameTextBox);
            ingredientsGroupBox.Controls.Add(ingredientMeasureLabel);
            ingredientsGroupBox.Controls.Add(ingredientMeasureTextBox);
            ingredientsGroupBox.Controls.Add(addIngredientButton);
            ingredientsGroupBox.Controls.Add(ingredientsListBox);
            ingredientsGroupBox.Controls.Add(removeIngredientButton);
            ingredientsGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            ingredientsGroupBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            ingredientsGroupBox.Location = new System.Drawing.Point(20, 375);
            ingredientsGroupBox.Name = "ingredientsGroupBox";
            ingredientsGroupBox.Size = new System.Drawing.Size(540, 280);
            ingredientsGroupBox.TabIndex = 10;
            ingredientsGroupBox.TabStop = false;
            ingredientsGroupBox.Text = "Ingredients";

            // ingredientNameLabel
            ingredientNameLabel.AutoSize = true;
            ingredientNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            ingredientNameLabel.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            ingredientNameLabel.Location = new System.Drawing.Point(10, 25);
            ingredientNameLabel.Name = "ingredientNameLabel";
            ingredientNameLabel.Size = new System.Drawing.Size(97, 19);
            ingredientNameLabel.TabIndex = 0;
            ingredientNameLabel.Text = "Ingredient Name";

            // ingredientNameTextBox
            ingredientNameTextBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ingredientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ingredientNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            ingredientNameTextBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            ingredientNameTextBox.Location = new System.Drawing.Point(10, 47);
            ingredientNameTextBox.Name = "ingredientNameTextBox";
            ingredientNameTextBox.Size = new System.Drawing.Size(255, 25);
            ingredientNameTextBox.TabIndex = 1;

            // ingredientMeasureLabel
            ingredientMeasureLabel.AutoSize = true;
            ingredientMeasureLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            ingredientMeasureLabel.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            ingredientMeasureLabel.Location = new System.Drawing.Point(275, 25);
            ingredientMeasureLabel.Name = "ingredientMeasureLabel";
            ingredientMeasureLabel.Size = new System.Drawing.Size(59, 19);
            ingredientMeasureLabel.TabIndex = 2;
            ingredientMeasureLabel.Text = "Measure";

            // ingredientMeasureTextBox
            ingredientMeasureTextBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ingredientMeasureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ingredientMeasureTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            ingredientMeasureTextBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            ingredientMeasureTextBox.Location = new System.Drawing.Point(275, 47);
            ingredientMeasureTextBox.Name = "ingredientMeasureTextBox";
            ingredientMeasureTextBox.Size = new System.Drawing.Size(255, 25);
            ingredientMeasureTextBox.TabIndex = 3;

            // addIngredientButton
            addIngredientButton.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            addIngredientButton.FlatAppearance.BorderSize = 0;
            addIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addIngredientButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            addIngredientButton.ForeColor = System.Drawing.Color.White;
            addIngredientButton.Location = new System.Drawing.Point(10, 78);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new System.Drawing.Size(520, 30);
            addIngredientButton.TabIndex = 4;
            addIngredientButton.Text = "Add Ingredient";
            addIngredientButton.UseVisualStyleBackColor = false;
            addIngredientButton.Click += AddIngredientButton_Click;

            // ingredientsListBox
            ingredientsListBox.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ingredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ingredientsListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            ingredientsListBox.ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            ingredientsListBox.ItemHeight = 18;
            ingredientsListBox.Location = new System.Drawing.Point(10, 115);
            ingredientsListBox.Name = "ingredientsListBox";
            ingredientsListBox.Size = new System.Drawing.Size(520, 110);
            ingredientsListBox.TabIndex = 5;

            // removeIngredientButton
            removeIngredientButton.BackColor = System.Drawing.Color.FromArgb(208, 0, 0);
            removeIngredientButton.FlatAppearance.BorderSize = 0;
            removeIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            removeIngredientButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            removeIngredientButton.ForeColor = System.Drawing.Color.White;
            removeIngredientButton.Location = new System.Drawing.Point(10, 240);
            removeIngredientButton.Name = "removeIngredientButton";
            removeIngredientButton.Size = new System.Drawing.Size(520, 30);
            removeIngredientButton.TabIndex = 6;
            removeIngredientButton.Text = "Remove Selected Ingredient";
            removeIngredientButton.UseVisualStyleBackColor = false;
            removeIngredientButton.Click += RemoveIngredientButton_Click;

            // submitButton
            submitButton.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            submitButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            submitButton.ForeColor = System.Drawing.Color.White;
            submitButton.Location = new System.Drawing.Point(20, 665);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(260, 40);
            submitButton.TabIndex = 11;
            submitButton.Text = "Create Drink";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += SubmitButton_Click;

            // cancelButton
            cancelButton.BackColor = System.Drawing.Color.FromArgb(208, 0, 0);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancelButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            cancelButton.ForeColor = System.Drawing.Color.White;
            cancelButton.Location = new System.Drawing.Point(300, 665);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(260, 40);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;

            // AddCustomDrinkForm
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            ClientSize = new System.Drawing.Size(600, 720);
            Controls.Add(mainPanel);
            Font = new System.Drawing.Font("Segoe UI", 12F);
            ForeColor = System.Drawing.Color.FromArgb(241, 241, 241);
            Name = "AddCustomDrinkForm";
            Text = "Add Custom Drink";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ingredientsGroupBox.ResumeLayout(false);
            ingredientsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label drinkNameLabel;
        private System.Windows.Forms.TextBox drinkNameTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label glassTypeLabel;
        private System.Windows.Forms.TextBox glassTypeTextBox;
        private System.Windows.Forms.Label alcoholicLabel;
        private System.Windows.Forms.ComboBox alcoholicComboBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox instructionsTextBox;
        private System.Windows.Forms.GroupBox ingredientsGroupBox;
        private System.Windows.Forms.Label ingredientNameLabel;
        private System.Windows.Forms.TextBox ingredientNameTextBox;
        private System.Windows.Forms.Label ingredientMeasureLabel;
        private System.Windows.Forms.TextBox ingredientMeasureTextBox;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
