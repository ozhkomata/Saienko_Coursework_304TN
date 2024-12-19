using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InternetProviderMenu.Controllers;

namespace InternetProviderMenu
{
    public partial class ServicesForm : Form
    {
        private ServiceController serviceController;
        private ErrorProvider errorProvider;

        public ServicesForm()
        {
            InitializeComponent();
            serviceController = new ServiceController();
            errorProvider = new ErrorProvider();
            ApplyCustomStyles();
            LoadServices();
            InitializeEvents();
        }

        private void ApplyCustomStyles()
        {
            CustomStyles.StyleForm(this);
            CustomStyles.StyleButton(addButton);
            CustomStyles.StyleButton(deleteButton);
            CustomStyles.StyleButton(backButton);
            CustomStyles.StyleListView(servicesListView);
            CustomStyles.StyleTextBox(serviceNameTextBox);
            CustomStyles.StyleTextBox(descriptionTextBox);
            CustomStyles.StyleTextBox(costTextBox);
            CustomStyles.StyleLabel(serviceNameLabel);
            CustomStyles.StyleLabel(descriptionLabel);
            CustomStyles.StyleLabel(costLabel);
        }

        private void InitializeEvents()
        {
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            backButton.Click += BackButton_Click;
            servicesListView.SelectedIndexChanged += ServicesListView_SelectedIndexChanged;
        }

        private void LoadServices()
        {
            servicesListView.Items.Clear();
            List<Service> services = serviceController.GetAllServices();
            foreach (var service in services)
            {
                ListViewItem item = new ListViewItem(service.ServiceId.ToString());
                item.SubItems.Add(service.ServiceName);
                item.SubItems.Add(service.Description);
                item.SubItems.Add(service.Cost.ToString("F2"));
                servicesListView.Items.Add(item);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var service = new Service
                {
                    ServiceName = serviceNameTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Cost = decimal.Parse(costTextBox.Text)
                };
                serviceController.AddService(service);
                LoadServices();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(serviceNameTextBox.Text))
            {
                errorProvider.SetError(serviceNameTextBox, "Введіть назву послуги.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                errorProvider.SetError(descriptionTextBox, "Введіть опис послуги.");
                isValid = false;
            }
            if (!decimal.TryParse(costTextBox.Text, out decimal cost) || cost <= 0)
            {
                errorProvider.SetError(costTextBox, "Введіть коректну вартість.");
                isValid = false;
            }
            return isValid;
        }

        private void ClearInputs()
        {
            serviceNameTextBox.Clear();
            descriptionTextBox.Clear();
            costTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (servicesListView.SelectedItems.Count > 0)
            {
                int serviceId = int.Parse(servicesListView.SelectedItems[0].SubItems[0].Text);
                serviceController.DeleteService(serviceId);
                LoadServices();
            }
        }

        private void ServicesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Додатково: можна реалізувати відображення деталей послуги при виборі зі списку
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}