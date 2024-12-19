namespace InternetProviderMenu
{
    partial class PaymentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView paymentsListView;
        private System.Windows.Forms.ColumnHeader paymentIdColumn;
        private System.Windows.Forms.ColumnHeader clientNameColumn;
        private System.Windows.Forms.ColumnHeader amountColumn;
        private System.Windows.Forms.ColumnHeader paymentDateColumn;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DateTimePicker paymentDatePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label dateLabel;

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
            this.paymentsListView = new System.Windows.Forms.ListView();
            this.paymentIdColumn = new System.Windows.Forms.ColumnHeader();
            this.clientNameColumn = new System.Windows.Forms.ColumnHeader();
            this.amountColumn = new System.Windows.Forms.ColumnHeader();
            this.paymentDateColumn = new System.Windows.Forms.ColumnHeader();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.paymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // paymentsListView
            // 
            this.paymentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.paymentIdColumn,
            this.clientNameColumn,
            this.amountColumn,
            this.paymentDateColumn});
            this.paymentsListView.Location = new System.Drawing.Point(350, 20);
            this.paymentsListView.Name = "paymentsListView";
            this.paymentsListView.Size = new System.Drawing.Size(400, 300);
            this.paymentsListView.TabIndex = 0;
            this.paymentsListView.UseCompatibleStateImageBehavior = false;
            this.paymentsListView.View = System.Windows.Forms.View.Details;
            // 
            // paymentIdColumn
            // 
            this.paymentIdColumn.Text = "ID";
            // 
            // clientNameColumn
            // 
            this.clientNameColumn.Text = "Клієнт";
            this.clientNameColumn.Width = 120;
            // 
            // amountColumn
            // 
            this.amountColumn.Text = "Сума";
            // 
            // paymentDateColumn
            // 
            this.paymentDateColumn.Text = "Дата платежу";
            this.paymentDateColumn.Width = 100;
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
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(120, 60);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 23);
            this.amountTextBox.TabIndex = 2;
            // 
            // paymentDatePicker
            // 
            this.paymentDatePicker.Location = new System.Drawing.Point(120, 100);
            this.paymentDatePicker.Name = "paymentDatePicker";
            this.paymentDatePicker.Size = new System.Drawing.Size(200, 23);
            this.paymentDatePicker.TabIndex = 3;
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
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(20, 63);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(39, 15);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Сума:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(20, 103);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(81, 15);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Дата платежу:";
            // 
            // PaymentsForm
            // 
            this.ClientSize = new System.Drawing.Size(774, 341);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.paymentDatePicker);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.paymentsListView);
            this.Name = "PaymentsForm";
            this.Text = "Платежі";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}