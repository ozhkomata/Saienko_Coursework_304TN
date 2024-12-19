namespace InternetProviderMenu
{
    partial class SupportTicketsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView ticketsListView;
        private System.Windows.Forms.ColumnHeader ticketIdColumn;
        private System.Windows.Forms.ColumnHeader clientNameColumn;
        private System.Windows.Forms.ColumnHeader issueDescriptionColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ColumnHeader createdAtColumn;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.TextBox issueDescriptionTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateStatusButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label issueDescriptionLabel;
        private System.Windows.Forms.Label statusLabel;

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
            this.ticketsListView = new System.Windows.Forms.ListView();
            this.ticketIdColumn = new System.Windows.Forms.ColumnHeader();
            this.clientNameColumn = new System.Windows.Forms.ColumnHeader();
            this.issueDescriptionColumn = new System.Windows.Forms.ColumnHeader();
            this.statusColumn = new System.Windows.Forms.ColumnHeader();
            this.createdAtColumn = new System.Windows.Forms.ColumnHeader();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.issueDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateStatusButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.issueDescriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ticketsListView
            // 
            this.ticketsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ticketIdColumn,
            this.clientNameColumn,
            this.issueDescriptionColumn,
            this.statusColumn,
            this.createdAtColumn});
            this.ticketsListView.Location = new System.Drawing.Point(350, 20);
            this.ticketsListView.Name = "ticketsListView";
            this.ticketsListView.Size = new System.Drawing.Size(600, 300);
            this.ticketsListView.TabIndex = 0;
            this.ticketsListView.UseCompatibleStateImageBehavior = false;
            this.ticketsListView.View = System.Windows.Forms.View.Details;
            // 
            // ticketIdColumn
            // 
            this.ticketIdColumn.Text = "ID";
            // 
            // clientNameColumn
            // 
            this.clientNameColumn.Text = "Клієнт";
            this.clientNameColumn.Width = 120;
            // 
            // issueDescriptionColumn
            // 
            this.issueDescriptionColumn.Text = "Опис проблеми";
            this.issueDescriptionColumn.Width = 200;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Статус";
            this.statusColumn.Width = 100;
            // 
            // createdAtColumn
            // 
            this.createdAtColumn.Text = "Дата створення";
            this.createdAtColumn.Width = 100;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(120, 20);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(200, 23);
            this.clientComboBox.TabIndex = 1;
            // 
            // issueDescriptionTextBox
            // 
            this.issueDescriptionTextBox.Location = new System.Drawing.Point(120, 60);
            this.issueDescriptionTextBox.Multiline = true;
            this.issueDescriptionTextBox.Name = "issueDescriptionTextBox";
            this.issueDescriptionTextBox.Size = new System.Drawing.Size(200, 80);
            this.issueDescriptionTextBox.TabIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(120, 150);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 23);
            this.statusComboBox.TabIndex = 3;
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
            // updateStatusButton
            // 
            this.updateStatusButton.Location = new System.Drawing.Point(120, 230);
            this.updateStatusButton.Name = "updateStatusButton";
            this.updateStatusButton.Size = new System.Drawing.Size(200, 30);
            this.updateStatusButton.TabIndex = 6;
            this.updateStatusButton.Text = "Оновити статус";
            this.updateStatusButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(120, 270);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 30);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(20, 23);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(45, 15);
            this.clientLabel.TabIndex = 8;
            this.clientLabel.Text = "Клієнт:";
            // 
            // issueDescriptionLabel
            // 
            this.issueDescriptionLabel.AutoSize = true;
            this.issueDescriptionLabel.Location = new System.Drawing.Point(20, 63);
            this.issueDescriptionLabel.Name = "issueDescriptionLabel";
            this.issueDescriptionLabel.Size = new System.Drawing.Size(94, 15);
            this.issueDescriptionLabel.TabIndex = 9;
            this.issueDescriptionLabel.Text = "Опис проблеми:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(20, 153);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 15);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Статус:";
            // 
            // SupportTicketsForm
            // 
            this.ClientSize = new System.Drawing.Size(974, 341);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.issueDescriptionLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.updateStatusButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.issueDescriptionTextBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.ticketsListView);
            this.Name = "SupportTicketsForm";
            this.Text = "Заявки підтримки";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}