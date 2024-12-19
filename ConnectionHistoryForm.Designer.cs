namespace InternetProviderMenu
{
    partial class ConnectionHistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView historyListView;
        private System.Windows.Forms.ColumnHeader historyIdColumn;
        private System.Windows.Forms.ColumnHeader clientNameColumn;
        private System.Windows.Forms.ColumnHeader startDateColumn;
        private System.Windows.Forms.ColumnHeader endDateColumn;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;

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
            this.historyListView = new System.Windows.Forms.ListView();
            this.historyIdColumn = new System.Windows.Forms.ColumnHeader();
            this.clientNameColumn = new System.Windows.Forms.ColumnHeader();
            this.startDateColumn = new System.Windows.Forms.ColumnHeader();
            this.endDateColumn = new System.Windows.Forms.ColumnHeader();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // historyListView
            // 
            this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.historyIdColumn,
            this.clientNameColumn,
            this.startDateColumn,
            this.endDateColumn});
            this.historyListView.Location = new System.Drawing.Point(350, 20);
            this.historyListView.Name = "historyListView";
            this.historyListView.Size = new System.Drawing.Size(500, 300);
            this.historyListView.TabIndex = 0;
            this.historyListView.UseCompatibleStateImageBehavior = false;
            this.historyListView.View = System.Windows.Forms.View.Details;
            // 
            // historyIdColumn
            // 
            this.historyIdColumn.Text = "ID";
            // 
            // clientNameColumn
            // 
            this.clientNameColumn.Text = "Клієнт";
            this.clientNameColumn.Width = 120;
            // 
            // startDateColumn
            // 
            this.startDateColumn.Text = "Дата початку";
            this.startDateColumn.Width = 100;
            // 
            // endDateColumn
            // 
            this.endDateColumn.Text = "Дата закінчення";
            this.endDateColumn.Width = 100;
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
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(120, 60);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 23);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(120, 100);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 23);
            this.endDatePicker.TabIndex = 3;
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
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(20, 23);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(45, 15);
            this.clientLabel.TabIndex = 7;
            this.clientLabel.Text = "Клієнт:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(20, 63);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(81, 15);
            this.startDateLabel.TabIndex = 8;
            this.startDateLabel.Text = "Дата початку:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(20, 103);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(97, 15);
            this.endDateLabel.TabIndex = 9;
            this.endDateLabel.Text = "Дата закінчення:";
            // 
            // ConnectionHistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(874, 341);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.historyListView);
            this.Name = "ConnectionHistoryForm";
            this.Text = "Історія підключень";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}