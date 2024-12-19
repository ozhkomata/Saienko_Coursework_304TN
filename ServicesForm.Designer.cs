namespace InternetProviderMenu
{
    partial class ServicesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView servicesListView;
        private System.Windows.Forms.ColumnHeader serviceIdColumn;
        private System.Windows.Forms.ColumnHeader serviceNameColumn;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
        private System.Windows.Forms.ColumnHeader costColumn;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label costLabel;

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
            this.servicesListView = new System.Windows.Forms.ListView();
            this.serviceIdColumn = new System.Windows.Forms.ColumnHeader();
            this.serviceNameColumn = new System.Windows.Forms.ColumnHeader();
            this.descriptionColumn = new System.Windows.Forms.ColumnHeader();
            this.costColumn = new System.Windows.Forms.ColumnHeader();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // servicesListView
            // 
            this.servicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serviceIdColumn,
            this.serviceNameColumn,
            this.descriptionColumn,
            this.costColumn});
            this.servicesListView.Location = new System.Drawing.Point(350, 20);
            this.servicesListView.Name = "servicesListView";
            this.servicesListView.Size = new System.Drawing.Size(500, 300);
            this.servicesListView.TabIndex = 0;
            this.servicesListView.UseCompatibleStateImageBehavior = false;
            this.servicesListView.View = System.Windows.Forms.View.Details;
            // 
            // serviceIdColumn
            // 
            this.serviceIdColumn.Text = "ID";
            // 
            // serviceNameColumn
            // 
            this.serviceNameColumn.Text = "Назва послуги";
            this.serviceNameColumn.Width = 120;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Text = "Опис";
            this.descriptionColumn.Width = 200;
            // 
            // costColumn
            // 
            this.costColumn.Text = "Вартість";
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(120, 20);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.serviceNameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(120, 60);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 80);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(120, 150);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(200, 23);
            this.costTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(120, 190);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 30);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(225, 190);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 30);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(120, 230);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 30);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Location = new System.Drawing.Point(20, 23);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(81, 15);
            this.serviceNameLabel.TabIndex = 7;
            this.serviceNameLabel.Text = "Назва послуги:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(20, 63);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(33, 15);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Опис:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(20, 153);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(56, 15);
            this.costLabel.TabIndex = 9;
            this.costLabel.Text = "Вартість:";
            // 
            // ServicesForm
            // 
            this.ClientSize = new System.Drawing.Size(874, 341);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.servicesListView);
            this.Name = "ServicesForm";
            this.Text = "Послуги";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}