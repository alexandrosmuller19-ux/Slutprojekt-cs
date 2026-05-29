namespace drinks_info
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            mainLayoutTable = new TableLayoutPanel();
            leftPanel = new Panel();
            categoriesListBox = new ListBox();
            customDrinksPanel = new Panel();
            customDrinksListBox = new ListBox();
            customDrinksButtonsPanel = new Panel();
            customDrinksButtonTable = new TableLayoutPanel();
            addCustomDrinkButton = new Button();
            editCustomDrinkButton = new Button();
            deleteCustomDrinkButton = new Button();
            customDrinksLabel = new Label();
            categoriesLabel = new Label();
            middlePanel = new Panel();
            drinksListBox = new ListBox();
            viewDetailsButton = new Button();
            drinksLabel = new Label();
            rightPanel = new Panel();
            drinkDetailsTextBox = new TextBox();
            drinkImagePictureBox = new PictureBox();
            statusLabel = new Label();
            mainPanel.SuspendLayout();
            mainLayoutTable.SuspendLayout();
            leftPanel.SuspendLayout();
            customDrinksPanel.SuspendLayout();
            customDrinksButtonsPanel.SuspendLayout();
            customDrinksButtonTable.SuspendLayout();
            middlePanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drinkImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(32, 32, 32);
            mainPanel.Controls.Add(mainLayoutTable);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(10, 10);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1180, 674);
            mainPanel.TabIndex = 0;
            // 
            // mainLayoutTable
            // 
            mainLayoutTable.ColumnCount = 3;
            mainLayoutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            mainLayoutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            mainLayoutTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayoutTable.Controls.Add(leftPanel, 0, 0);
            mainLayoutTable.Controls.Add(middlePanel, 1, 0);
            mainLayoutTable.Controls.Add(rightPanel, 2, 0);
            mainLayoutTable.Dock = DockStyle.Fill;
            mainLayoutTable.Location = new Point(0, 0);
            mainLayoutTable.Name = "mainLayoutTable";
            mainLayoutTable.RowCount = 1;
            mainLayoutTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutTable.Size = new Size(1180, 674);
            mainLayoutTable.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(32, 32, 32);
            leftPanel.Controls.Add(categoriesListBox);
            leftPanel.Controls.Add(customDrinksPanel);
            leftPanel.Controls.Add(categoriesLabel);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(3, 3);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(0, 0, 10, 0);
            leftPanel.Size = new Size(253, 668);
            leftPanel.TabIndex = 0;
            // 
            // categoriesListBox
            // 
            categoriesListBox.BackColor = Color.FromArgb(45, 45, 45);
            categoriesListBox.BorderStyle = BorderStyle.FixedSingle;
            categoriesListBox.Dock = DockStyle.Fill;
            categoriesListBox.Font = new Font("Segoe UI", 11F);
            categoriesListBox.ForeColor = Color.FromArgb(241, 241, 241);
            categoriesListBox.ItemHeight = 25;
            categoriesListBox.Location = new Point(0, 35);
            categoriesListBox.Name = "categoriesListBox";
            categoriesListBox.Size = new Size(243, 413);
            categoriesListBox.TabIndex = 1;
            categoriesListBox.SelectedIndexChanged += CategoriesListBox_SelectedIndexChanged;
            // 
            // customDrinksPanel
            // 
            customDrinksPanel.BackColor = Color.FromArgb(32, 32, 32);
            customDrinksPanel.Controls.Add(customDrinksListBox);
            customDrinksPanel.Controls.Add(customDrinksButtonsPanel);
            customDrinksPanel.Controls.Add(customDrinksLabel);
            customDrinksPanel.Dock = DockStyle.Bottom;
            customDrinksPanel.Location = new Point(0, 448);
            customDrinksPanel.Name = "customDrinksPanel";
            customDrinksPanel.Padding = new Padding(0, 15, 0, 0);
            customDrinksPanel.Size = new Size(243, 220);
            customDrinksPanel.TabIndex = 2;
            customDrinksPanel.Paint += customDrinksPanel_Paint_1;
            // 
            // customDrinksListBox
            // 
            customDrinksListBox.BackColor = Color.FromArgb(45, 45, 45);
            customDrinksListBox.BorderStyle = BorderStyle.FixedSingle;
            customDrinksListBox.Dock = DockStyle.Fill;
            customDrinksListBox.Font = new Font("Segoe UI", 11F);
            customDrinksListBox.ForeColor = Color.FromArgb(241, 241, 241);
            customDrinksListBox.ItemHeight = 25;
            customDrinksListBox.Location = new Point(0, 50);
            customDrinksListBox.Name = "customDrinksListBox";
            customDrinksListBox.Size = new Size(243, 125);
            customDrinksListBox.TabIndex = 1;
            customDrinksListBox.SelectedIndexChanged += CustomDrinksListBox_SelectedIndexChanged;
            // 
            // customDrinksButtonsPanel
            // 
            customDrinksButtonsPanel.BackColor = Color.FromArgb(32, 32, 32);
            customDrinksButtonsPanel.Controls.Add(customDrinksButtonTable);
            customDrinksButtonsPanel.Dock = DockStyle.Bottom;
            customDrinksButtonsPanel.Location = new Point(0, 175);
            customDrinksButtonsPanel.Name = "customDrinksButtonsPanel";
            customDrinksButtonsPanel.Padding = new Padding(0, 5, 0, 0);
            customDrinksButtonsPanel.Size = new Size(243, 45);
            customDrinksButtonsPanel.TabIndex = 2;
            // 
            // customDrinksButtonTable
            // 
            customDrinksButtonTable.ColumnCount = 3;
            customDrinksButtonTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            customDrinksButtonTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            customDrinksButtonTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            customDrinksButtonTable.Controls.Add(addCustomDrinkButton, 0, 0);
            customDrinksButtonTable.Controls.Add(editCustomDrinkButton, 1, 0);
            customDrinksButtonTable.Controls.Add(deleteCustomDrinkButton, 2, 0);
            customDrinksButtonTable.Dock = DockStyle.Fill;
            customDrinksButtonTable.Location = new Point(0, 5);
            customDrinksButtonTable.Name = "customDrinksButtonTable";
            customDrinksButtonTable.RowCount = 1;
            customDrinksButtonTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            customDrinksButtonTable.Size = new Size(243, 40);
            customDrinksButtonTable.TabIndex = 0;
            // 
            // addCustomDrinkButton
            // 
            addCustomDrinkButton.BackColor = Color.FromArgb(16, 124, 16);
            addCustomDrinkButton.Dock = DockStyle.Fill;
            addCustomDrinkButton.FlatAppearance.BorderSize = 0;
            addCustomDrinkButton.FlatStyle = FlatStyle.Flat;
            addCustomDrinkButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addCustomDrinkButton.ForeColor = Color.White;
            addCustomDrinkButton.Location = new Point(0, 0);
            addCustomDrinkButton.Margin = new Padding(0, 0, 2, 0);
            addCustomDrinkButton.Name = "addCustomDrinkButton";
            addCustomDrinkButton.Size = new Size(79, 40);
            addCustomDrinkButton.TabIndex = 0;
            addCustomDrinkButton.Text = "Add";
            addCustomDrinkButton.UseVisualStyleBackColor = false;
            addCustomDrinkButton.Click += AddCustomDrinkButton_Click;
            // 
            // editCustomDrinkButton
            // 
            editCustomDrinkButton.BackColor = Color.FromArgb(0, 120, 215);
            editCustomDrinkButton.Dock = DockStyle.Fill;
            editCustomDrinkButton.FlatAppearance.BorderSize = 0;
            editCustomDrinkButton.FlatStyle = FlatStyle.Flat;
            editCustomDrinkButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editCustomDrinkButton.ForeColor = Color.White;
            editCustomDrinkButton.Location = new Point(83, 0);
            editCustomDrinkButton.Margin = new Padding(2, 0, 2, 0);
            editCustomDrinkButton.Name = "editCustomDrinkButton";
            editCustomDrinkButton.Size = new Size(77, 40);
            editCustomDrinkButton.TabIndex = 1;
            editCustomDrinkButton.Text = "Edit";
            editCustomDrinkButton.UseVisualStyleBackColor = false;
            editCustomDrinkButton.Click += EditCustomDrinkButton_Click;
            // 
            // deleteCustomDrinkButton
            // 
            deleteCustomDrinkButton.BackColor = Color.FromArgb(208, 0, 0);
            deleteCustomDrinkButton.Dock = DockStyle.Fill;
            deleteCustomDrinkButton.FlatAppearance.BorderSize = 0;
            deleteCustomDrinkButton.FlatStyle = FlatStyle.Flat;
            deleteCustomDrinkButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteCustomDrinkButton.ForeColor = Color.White;
            deleteCustomDrinkButton.Location = new Point(164, 0);
            deleteCustomDrinkButton.Margin = new Padding(2, 0, 0, 0);
            deleteCustomDrinkButton.Name = "deleteCustomDrinkButton";
            deleteCustomDrinkButton.Size = new Size(79, 40);
            deleteCustomDrinkButton.TabIndex = 2;
            deleteCustomDrinkButton.Text = "Delete";
            deleteCustomDrinkButton.UseVisualStyleBackColor = false;
            deleteCustomDrinkButton.Click += DeleteCustomDrinkButton_Click;
            // 
            // customDrinksLabel
            // 
            customDrinksLabel.BackColor = Color.FromArgb(32, 32, 32);
            customDrinksLabel.Dock = DockStyle.Top;
            customDrinksLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            customDrinksLabel.ForeColor = Color.FromArgb(241, 241, 241);
            customDrinksLabel.Location = new Point(0, 15);
            customDrinksLabel.Name = "customDrinksLabel";
            customDrinksLabel.Size = new Size(243, 35);
            customDrinksLabel.TabIndex = 0;
            customDrinksLabel.Text = "MY CUSTOM DRINKS";
            customDrinksLabel.Click += customDrinksLabel_Click_1;
            // 
            // categoriesLabel
            // 
            categoriesLabel.BackColor = Color.FromArgb(32, 32, 32);
            categoriesLabel.Dock = DockStyle.Top;
            categoriesLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            categoriesLabel.ForeColor = Color.FromArgb(241, 241, 241);
            categoriesLabel.Location = new Point(0, 0);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(243, 35);
            categoriesLabel.TabIndex = 0;
            categoriesLabel.Text = "CATEGORIES";
            // 
            // middlePanel
            // 
            middlePanel.BackColor = Color.FromArgb(32, 32, 32);
            middlePanel.Controls.Add(drinksListBox);
            middlePanel.Controls.Add(viewDetailsButton);
            middlePanel.Controls.Add(drinksLabel);
            middlePanel.Dock = DockStyle.Fill;
            middlePanel.Location = new Point(262, 3);
            middlePanel.Name = "middlePanel";
            middlePanel.Padding = new Padding(10, 0, 10, 0);
            middlePanel.Size = new Size(324, 668);
            middlePanel.TabIndex = 1;
            // 
            // drinksListBox
            // 
            drinksListBox.BackColor = Color.FromArgb(45, 45, 45);
            drinksListBox.BorderStyle = BorderStyle.FixedSingle;
            drinksListBox.Dock = DockStyle.Fill;
            drinksListBox.Font = new Font("Segoe UI", 11F);
            drinksListBox.ForeColor = Color.FromArgb(241, 241, 241);
            drinksListBox.ItemHeight = 25;
            drinksListBox.Location = new Point(10, 35);
            drinksListBox.Name = "drinksListBox";
            drinksListBox.Size = new Size(304, 583);
            drinksListBox.TabIndex = 1;
            drinksListBox.SelectedIndexChanged += DrinksListBox_SelectedIndexChanged;
            // 
            // viewDetailsButton
            // 
            viewDetailsButton.BackColor = Color.FromArgb(0, 120, 215);
            viewDetailsButton.Dock = DockStyle.Bottom;
            viewDetailsButton.FlatAppearance.BorderSize = 0;
            viewDetailsButton.FlatStyle = FlatStyle.Flat;
            viewDetailsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            viewDetailsButton.ForeColor = Color.White;
            viewDetailsButton.Location = new Point(10, 618);
            viewDetailsButton.Margin = new Padding(0);
            viewDetailsButton.Name = "viewDetailsButton";
            viewDetailsButton.Size = new Size(304, 50);
            viewDetailsButton.TabIndex = 2;
            viewDetailsButton.Text = "REFRESH DETAILS";
            viewDetailsButton.UseVisualStyleBackColor = false;
            viewDetailsButton.Click += ViewDetailsButton_Click;
            // 
            // drinksLabel
            // 
            drinksLabel.BackColor = Color.FromArgb(32, 32, 32);
            drinksLabel.Dock = DockStyle.Top;
            drinksLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            drinksLabel.ForeColor = Color.FromArgb(241, 241, 241);
            drinksLabel.Location = new Point(10, 0);
            drinksLabel.Name = "drinksLabel";
            drinksLabel.Size = new Size(304, 35);
            drinksLabel.TabIndex = 0;
            drinksLabel.Text = "DRINKS";
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(32, 32, 32);
            rightPanel.Controls.Add(drinkDetailsTextBox);
            rightPanel.Controls.Add(drinkImagePictureBox);
            rightPanel.Controls.Add(statusLabel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(592, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10, 0, 0, 0);
            rightPanel.Size = new Size(585, 668);
            rightPanel.TabIndex = 3;
            rightPanel.Paint += rightPanel_Paint;
            rightPanel.Resize += RightPanel_Resize;
            // 
            // drinkDetailsTextBox
            // 
            drinkDetailsTextBox.BackColor = Color.FromArgb(45, 45, 45);
            drinkDetailsTextBox.BorderStyle = BorderStyle.FixedSingle;
            drinkDetailsTextBox.Dock = DockStyle.Fill;
            drinkDetailsTextBox.Font = new Font("Segoe UI", 12F);
            drinkDetailsTextBox.ForeColor = Color.FromArgb(241, 241, 241);
            drinkDetailsTextBox.Location = new Point(10, 317);
            drinkDetailsTextBox.Multiline = true;
            drinkDetailsTextBox.Name = "drinkDetailsTextBox";
            drinkDetailsTextBox.ReadOnly = true;
            drinkDetailsTextBox.ScrollBars = ScrollBars.Vertical;
            drinkDetailsTextBox.Size = new Size(575, 351);
            drinkDetailsTextBox.TabIndex = 2;
            // 
            // drinkImagePictureBox
            // 
            drinkImagePictureBox.BackColor = Color.FromArgb(45, 45, 45);
            drinkImagePictureBox.BorderStyle = BorderStyle.FixedSingle;
            drinkImagePictureBox.Dock = DockStyle.Top;
            drinkImagePictureBox.Location = new Point(10, 27);
            drinkImagePictureBox.Name = "drinkImagePictureBox";
            drinkImagePictureBox.Size = new Size(575, 290);
            drinkImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            drinkImagePictureBox.TabIndex = 0;
            drinkImagePictureBox.TabStop = false;
            // 
            // statusLabel
            // 
            statusLabel.BackColor = Color.FromArgb(32, 32, 32);
            statusLabel.Dock = DockStyle.Top;
            statusLabel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            statusLabel.ForeColor = Color.FromArgb(0, 120, 215);
            statusLabel.Location = new Point(10, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(575, 27);
            statusLabel.TabIndex = 1;
            statusLabel.Text = "Loading categories...";
            statusLabel.TextAlign = ContentAlignment.MiddleRight;
            statusLabel.Click += statusLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1200, 694);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(241, 241, 241);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Drink Finder - CocktailDB";
            mainPanel.ResumeLayout(false);
            mainLayoutTable.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            customDrinksPanel.ResumeLayout(false);
            customDrinksButtonsPanel.ResumeLayout(false);
            customDrinksButtonTable.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)drinkImagePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.ListBox drinksListBox;
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.TextBox drinkDetailsTextBox;
        private System.Windows.Forms.PictureBox drinkImagePictureBox;
        private Panel mainPanel;
        private Panel leftPanel;
        private Panel middlePanel;
        private Panel rightPanel;
        private Label statusLabel;
        private Panel customDrinksPanel;
        private Label customDrinksLabel;
        private ListBox customDrinksListBox;
        private Panel customDrinksButtonsPanel;
        private Button addCustomDrinkButton;
        private Button editCustomDrinkButton;
        private Button deleteCustomDrinkButton;
        private TableLayoutPanel mainLayoutTable;
        private TableLayoutPanel customDrinksButtonTable;
    }
}