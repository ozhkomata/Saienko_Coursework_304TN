namespace InternetProviderMenu
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button plansButton;
        private System.Windows.Forms.Button servicesButton;
        private System.Windows.Forms.Button paymentsButton;
        private System.Windows.Forms.Button connectionHistoryButton;
        private System.Windows.Forms.Button supportTicketsButton;

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
            this.clientsButton = new System.Windows.Forms.Button();
            this.plansButton = new System.Windows.Forms.Button();
            this.servicesButton = new System.Windows.Forms.Button();
            this.paymentsButton = new System.Windows.Forms.Button();
            this.connectionHistoryButton = new System.Windows.Forms.Button();
            this.supportTicketsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientsButton
            // 
            this.clientsButton.Location = new System.Drawing.Point(30, 30);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(200, 40);
            this.clientsButton.TabIndex = 0;
            this.clientsButton.Text = "Клієнти";
            this.clientsButton.UseVisualStyleBackColor = true;
            // 
            // plansButton
            // 
            this.plansButton.Location = new System.Drawing.Point(30, 80);
            this.plansButton.Name = "plansButton";
            this.plansButton.Size = new System.Drawing.Size(200, 40);
            this.plansButton.TabIndex = 1;
            this.plansButton.Text = "Тарифні плани";
            this.plansButton.UseVisualStyleBackColor = true;
            // 
            // servicesButton
            // 
            this.servicesButton.Location = new System.Drawing.Point(30, 130);
            this.servicesButton.Name = "servicesButton";
            this.servicesButton.Size = new System.Drawing.Size(200, 40);
            this.servicesButton.TabIndex = 2;
            this.servicesButton.Text = "Послуги";
            this.servicesButton.UseVisualStyleBackColor = true;
            // 
            // paymentsButton
            // 
            this.paymentsButton.Location = new System.Drawing.Point(30, 180);
            this.paymentsButton.Name = "paymentsButton";
            this.paymentsButton.Size = new System.Drawing.Size(200, 40);
            this.paymentsButton.TabIndex = 3;
            this.paymentsButton.Text = "Платежі";
            this.paymentsButton.UseVisualStyleBackColor = true;
            // 
            // connectionHistoryButton
            // 
            this.connectionHistoryButton.Location = new System.Drawing.Point(30, 230);
            this.connectionHistoryButton.Name = "connectionHistoryButton";
            this.connectionHistoryButton.Size = new System.Drawing.Size(200, 40);
            this.connectionHistoryButton.TabIndex = 4;
            this.connectionHistoryButton.Text = "Історія підключень";
            this.connectionHistoryButton.UseVisualStyleBackColor = true;
            // 
            // supportTicketsButton
            // 
            this.supportTicketsButton.Location = new System.Drawing.Point(30, 280);
            this.supportTicketsButton.Name = "supportTicketsButton";
            this.supportTicketsButton.Size = new System.Drawing.Size(200, 40);
            this.supportTicketsButton.TabIndex = 5;
            this.supportTicketsButton.Text = "Заявки підтримки";
            this.supportTicketsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(260, 360);
            this.Controls.Add(this.supportTicketsButton);
            this.Controls.Add(this.connectionHistoryButton);
            this.Controls.Add(this.paymentsButton);
            this.Controls.Add(this.servicesButton);
            this.Controls.Add(this.plansButton);
            this.Controls.Add(this.clientsButton);
            this.Name = "MainForm";
            this.Text = "Меню провайдера";
            this.ResumeLayout(false);
        }
    }
}