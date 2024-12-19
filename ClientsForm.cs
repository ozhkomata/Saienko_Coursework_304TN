using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InternetProviderMenu.Controllers;

namespace InternetProviderMenu
{
    public partial class ClientsForm : Form
    {
        private ClientController clientController;
        private ErrorProvider errorProvider;

        public ClientsForm()
        {
            InitializeComponent();
            clientController = new ClientController();
            errorProvider = new ErrorProvider();
            ApplyCustomStyles();
            LoadClients();
            InitializeEvents();
            LoadPlans();
            LoadServices();
        }

        private void ApplyCustomStyles()
        {
            CustomStyles.StyleForm(this);
            CustomStyles.StyleButton(addButton);
            CustomStyles.StyleButton(deleteButton);
            CustomStyles.StyleButton(backButton);
            CustomStyles.StyleListView(clientsListView);
            CustomStyles.StyleTextBox(nameTextBox);
            CustomStyles.StyleTextBox(addressTextBox);
            CustomStyles.StyleTextBox(emailTextBox);
            CustomStyles.StyleTextBox(phoneTextBox);
            CustomStyles.StyleComboBox(planComboBox);
            CustomStyles.StyleComboBox(serviceComboBox);
            CustomStyles.StyleLabel(nameLabel);
            CustomStyles.StyleLabel(addressLabel);
            CustomStyles.StyleLabel(emailLabel);
            CustomStyles.StyleLabel(phoneLabel);
            CustomStyles.StyleLabel(planLabel);
            CustomStyles.StyleLabel(serviceLabel);
        }

        private void InitializeEvents()
        {
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            backButton.Click += BackButton_Click;
            clientsListView.SelectedIndexChanged += ClientsListView_SelectedIndexChanged;
        }

        private void LoadClients()
        {
            clientsListView.Items.Clear();
            List<Client> clients = clientController.GetAllClients();
            foreach (var client in clients)
            {
                ListViewItem item = new ListViewItem(client.ClientId.ToString());
                item.SubItems.Add(client.Name);
                item.SubItems.Add(client.Address);
                item.SubItems.Add(client.Email);
                item.SubItems.Add(client.Phone);
                item.SubItems.Add(client.PlanName);
                item.SubItems.Add(client.ServiceName);
                clientsListView.Items.Add(item);
            }
        }

        private void LoadPlans()
        {
            var plans = clientController.GetAllPlans();
            planComboBox.DataSource = plans;
            planComboBox.DisplayMember = "PlanName";
            planComboBox.ValueMember = "PlanId";
        }

        private void LoadServices()
        {
            var services = clientController.GetAllServices();
            serviceComboBox.DataSource = services;
            serviceComboBox.DisplayMember = "ServiceName";
            serviceComboBox.ValueMember = "ServiceId";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var client = new Client
                {
                    Name = nameTextBox.Text,
                    Address = addressTextBox.Text,
                    Email = emailTextBox.Text,
                    Phone = phoneTextBox.Text,
                    PlanId = (int)planComboBox.SelectedValue,
                    ServiceId = (int?)serviceComboBox.SelectedValue
                };
                clientController.AddClient(client);
                LoadClients();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errorProvider.SetError(nameTextBox, "Введіть ім'я клієнта.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                errorProvider.SetError(addressTextBox, "Введіть адресу клієнта.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                errorProvider.SetError(emailTextBox, "Введіть email клієнта.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                errorProvider.SetError(phoneTextBox, "Введіть телефон клієнта.");
                isValid = false;
            }
            return isValid;
        }

        private void ClearInputs()
        {
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (clientsListView.SelectedItems.Count > 0)
            {
                int clientId = int.Parse(clientsListView.SelectedItems[0].SubItems[0].Text);
                clientController.DeleteClient(clientId);
                LoadClients();
            }
        }

        private void ClientsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Додатково: можна реалізувати відображення деталей клієнта при виборі зі списку
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}