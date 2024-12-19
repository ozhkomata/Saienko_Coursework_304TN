using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InternetProviderMenu.Controllers;

namespace InternetProviderMenu
{
    public partial class PlansForm : Form
    {
        private PlanController planController;
        private ErrorProvider errorProvider;

        public PlansForm()
        {
            InitializeComponent();
            planController = new PlanController();
            errorProvider = new ErrorProvider();
            ApplyCustomStyles();
            LoadPlans();
            InitializeEvents();
        }

        private void ApplyCustomStyles()
        {
            CustomStyles.StyleForm(this);
            CustomStyles.StyleButton(addButton);
            CustomStyles.StyleButton(deleteButton);
            CustomStyles.StyleButton(backButton);
            CustomStyles.StyleListView(plansListView);
            CustomStyles.StyleTextBox(planNameTextBox);
            CustomStyles.StyleTextBox(priceTextBox);
            CustomStyles.StyleTextBox(speedTextBox);
            CustomStyles.StyleLabel(planNameLabel);
            CustomStyles.StyleLabel(priceLabel);
            CustomStyles.StyleLabel(speedLabel);
        }

        private void InitializeEvents()
        {
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            backButton.Click += BackButton_Click;
            plansListView.SelectedIndexChanged += PlansListView_SelectedIndexChanged;
        }

        private void LoadPlans()
        {
            plansListView.Items.Clear();
            List<Plan> plans = planController.GetAllPlans();
            foreach (var plan in plans)
            {
                ListViewItem item = new ListViewItem(plan.PlanId.ToString());
                item.SubItems.Add(plan.PlanName);
                item.SubItems.Add(plan.Price.ToString("F2"));
                item.SubItems.Add(plan.Speed);
                plansListView.Items.Add(item);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var plan = new Plan
                {
                    PlanName = planNameTextBox.Text,
                    Price = decimal.Parse(priceTextBox.Text),
                    Speed = speedTextBox.Text
                };
                planController.AddPlan(plan);
                LoadPlans();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(planNameTextBox.Text))
            {
                errorProvider.SetError(planNameTextBox, "Введіть назву плану.");
                isValid = false;
            }
            if (!decimal.TryParse(priceTextBox.Text, out decimal price) || price <= 0)
            {
                errorProvider.SetError(priceTextBox, "Введіть коректну ціну.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(speedTextBox.Text))
            {
                errorProvider.SetError(speedTextBox, "Введіть швидкість.");
                isValid = false;
            }
            return isValid;
        }

        private void ClearInputs()
        {
            planNameTextBox.Clear();
            priceTextBox.Clear();
            speedTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (plansListView.SelectedItems.Count > 0)
            {
                int planId = int.Parse(plansListView.SelectedItems[0].SubItems[0].Text);
                planController.DeletePlan(planId);
                LoadPlans();
            }
        }

        private void PlansListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Додатково: можна реалізувати відображення деталей плану при виборі зі списку
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}