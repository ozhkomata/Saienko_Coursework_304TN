namespace InternetProviderMenu
{
    partial class PlansForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView plansListView;
        private System.Windows.Forms.ColumnHeader planIdColumn;
        private System.Windows.Forms.ColumnHeader planNameColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.ColumnHeader speedColumn;
        private System.Windows.Forms.TextBox planNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label planNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label speedLabel;

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
            this.plansListView = new System.Windows.Forms.ListView();
            this.planIdColumn = new System.Windows.Forms.ColumnHeader();
            this.planNameColumn = new System.Windows.Forms.ColumnHeader();
            this.priceColumn = new System.Windows.Forms.ColumnHeader();
            this.speedColumn = new System.Windows.Forms.ColumnHeader();
            this.planNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.planNameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plansListView
            // 
            this.plansListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.planIdColumn,
            this.planNameColumn,
            this.priceColumn,
            this.speedColumn});
            this.plansListView.Location = new System.Drawing.Point(350, 20);
            this.plansListView.Name = "plansListView";
            this.plansListView.Size = new System.Drawing.Size(400, 300);
            this.plansListView.TabIndex = 0;
            this.plansListView.UseCompatibleStateImageBehavior = false;
            this.plansListView.View = System.Windows.Forms.View.Details;
            // 
            // planIdColumn
            // 
            this.planIdColumn.Text = "ID";
            // 
            // planNameColumn
            // 
            this.planNameColumn.Text = "Назва плану";
            this.planNameColumn.Width = 120;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Ціна";
            // 
            // speedColumn
            // 
            this.speedColumn.Text = "Швидкість";
            this.speedColumn.Width = 100;
            // 
            // planNameTextBox
            // 
            this.planNameTextBox.Location = new System.Drawing.Point(120, 20);
            this.planNameTextBox.Name = "planNameTextBox";
            this.planNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.planNameTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(120, 60);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 23);
            this.priceTextBox.TabIndex = 2;
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(120, 100);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(200, 23);
            this.speedTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(120, 140);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 30);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(225, 140);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 30);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(120, 180);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 30);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // planNameLabel
            // 
            this.planNameLabel.AutoSize = true;
            this.planNameLabel.Location = new System.Drawing.Point(20, 23);
            this.planNameLabel.Name = "planNameLabel";
            this.planNameLabel.Size = new System.Drawing.Size(79, 15);
            this.planNameLabel.TabIndex = 7;
            this.planNameLabel.Text = "Назва плану:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(20, 63);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 15);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Ціна:";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(20, 103);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(71, 15);
            this.speedLabel.TabIndex = 9;
            this.speedLabel.Text = "Швидкість:";
            // 
            // PlansForm
            // 
            this.ClientSize = new System.Drawing.Size(774, 341);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.planNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.planNameTextBox);
            this.Controls.Add(this.plansListView);
            this.Name = "PlansForm";
            this.Text = "Тарифні плани";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}