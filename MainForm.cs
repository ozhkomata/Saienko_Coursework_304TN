using System;
using System.Windows.Forms;

namespace InternetProviderMenu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ApplyCustomStyles();
            InitializeEvents();
        }

        private void ApplyCustomStyles()
        {
            CustomStyles.StyleForm(this);
            CustomStyles.StyleButton(clientsButton);
            CustomStyles.StyleButton(plansButton);
            CustomStyles.StyleButton(servicesButton);
            CustomStyles.StyleButton(paymentsButton);
            CustomStyles.StyleButton(connectionHistoryButton);
            CustomStyles.StyleButton(supportTicketsButton);
        }

        private void InitializeEvents()
        {
            clientsButton.Click += ClientsButton_Click;
            plansButton.Click += PlansButton_Click;
            servicesButton.Click += ServicesButton_Click;
            paymentsButton.Click += PaymentsButton_Click;
            connectionHistoryButton.Click += ConnectionHistoryButton_Click;
            supportTicketsButton.Click += SupportTicketsButton_Click;
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
            this.Show();
        }

        private void PlansButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlansForm plansForm = new PlansForm();
            plansForm.ShowDialog();
            this.Show();
        }

        private void ServicesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.ShowDialog();
            this.Show();
        }

        private void PaymentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentsForm paymentsForm = new PaymentsForm();
            paymentsForm.ShowDialog();
            this.Show();
        }

        private void ConnectionHistoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectionHistoryForm connectionHistoryForm = new ConnectionHistoryForm();
            connectionHistoryForm.ShowDialog();
            this.Show();
        }

        private void SupportTicketsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportTicketsForm supportTicketsForm = new SupportTicketsForm();
            supportTicketsForm.ShowDialog();
            this.Show();
        }
    }
}