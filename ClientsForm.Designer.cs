namespace InternetProviderMenu
{
    partial class ClientsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView clientsListView;
        private System.Windows.Forms.ColumnHeader clientIdColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader addressColumn;
        private System.Windows.Forms.ColumnHeader emailColumn;
        private System.Windows.Forms.ColumnHeader phoneColumn;
        private System.Windows.Forms.ColumnHeader planColumn;
        private System.Windows.Forms.ColumnHeader serviceColumn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox planComboBox;
        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.Label serviceLabel;

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
            this.clientsListView = new System.Windows.Forms.ListView();
            this.clientIdColumn = new System.Windows.Forms.ColumnHeader();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.addressColumn = new System.Windows.Forms.ColumnHeader();
            this.emailColumn = new System.Windows.Forms.ColumnHeader();
            this.phoneColumn = new System.Windows.Forms.ColumnHeader();
            this.planColumn = new System.Windows.Forms.ColumnHeader();
            this.serviceColumn = new System.Windows.Forms.ColumnHeader();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.planComboBox = new System.Windows.Forms.ComboBox();
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.planLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientsListView
            // 
            this.clientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clientIdColumn,
            this.nameColumn,
            this.addressColumn,
            this.emailColumn,
            this.phoneColumn,
            this.planColumn,
            this.serviceColumn});
            this.clientsListView.Location = new System.Drawing.Point(350, 20);
            this.clientsListView.Name = "clientsListView";
            this.clientsListView.Size = new System.Drawing.Size(600, 400);
            this.clientsListView.TabIndex = 0;
            this.clientsListView.UseCompatibleStateImageBehavior = false;
            // 
            // clientIdColumn
            // 
            this.clientIdColumn.Text = "ID";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Ім'я";
            // 
            // addressColumn
            // 
            this.addressColumn.Text = "Адреса";
            // 
            // emailColumn
            // 
            this.emailColumn.Text = "Email";
            // 
            // phoneColumn
            // 
            this.phoneColumn.Text = "Телефон";
            // 
            // planColumn
            // 
            this.planColumn.Text = "Тарифний план";
            // 
            // serviceColumn
            // 
            this.serviceColumn.Text = "Послуга";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(120, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(120, 60);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 23);
            this.addressTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(120, 100);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 23);
            this.emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(120, 140);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 23);
            this.phoneTextBox.TabIndex = 4;
            // 
            // planComboBox
            // 
            this.planComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.planComboBox.FormattingEnabled = true;
            this.planComboBox.Location = new System.Drawing.Point(120, 180);
            this.planComboBox.Name = "planComboBox";
            this.planComboBox.Size = new System.Drawing.Size(200, 23);
            this.planComboBox.TabIndex = 5;
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Location = new System.Drawing.Point(120, 220);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(200, 23);
            this.serviceComboBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(120, 260);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 30);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(225, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 30);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(120, 300);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 30);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 15);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Ім'я:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(20, 63);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(51, 15);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "Адреса:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(20, 103);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 15);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(20, 143);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(58, 15);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Телефон:";
            // 
            // planLabel
            // 
            this.planLabel.AutoSize = true;
            this.planLabel.Location = new System.Drawing.Point(20, 183);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(85, 15);
            this.planLabel.TabIndex = 14;
            this.planLabel.Text = "Тарифний план:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(20, 223);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(54, 15);
            this.serviceLabel.TabIndex = 15;
            this.serviceLabel.Text = "Послуга:";
            // 
            // ClientsForm
            // 
            this.ClientSize = new System.Drawing.Size(974, 441);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.planLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.serviceComboBox);
            this.Controls.Add(this.planComboBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.clientsListView);
            this.Name = "ClientsForm";
            this.Text = "Клієнти";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}