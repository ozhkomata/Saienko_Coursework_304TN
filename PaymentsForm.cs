using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InternetProviderMenu.Controllers;

namespace InternetProviderMenu
{
    public partial class PaymentsForm : Form
    {
        private PaymentController paymentController;
        private ErrorProvider errorProvider;

        public PaymentsForm()
        {
            InitializeComponent();
            paymentController = new PaymentController();
            errorProvider = new ErrorProvider();
            ApplyCustomStyles();
            LoadPayments();
            InitializeEvents();
            LoadClients();
        }

        private void ApplyCustomStyles()
        {
            CustomStyles.StyleForm(this);
            CustomStyles.StyleButton(addButton);
            CustomStyles.StyleButton(deleteButton);
            CustomStyles.StyleButton(backButton);
            CustomStyles.StyleListView(paymentsListView);
            CustomStyles.StyleComboBox(clientComboBox);
            CustomStyles.StyleTextBox(amountTextBox);
            CustomStyles.StyleLabel(clientLabel);
            CustomStyles.StyleLabel(amountLabel);
            CustomStyles.StyleLabel(dateLabel);
        }

        private void InitializeEvents()
        {
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            backButton.Click += BackButton_Click;
            paymentsListView.SelectedIndexChanged += PaymentsListView_SelectedIndexChanged;
        }

        private void LoadPayments()
        {
            paymentsListView.Items.Clear();
            List<Payment> payments = paymentController.GetAllPayments();
            foreach (var payment in payments)
            {
                ListViewItem item = new ListViewItem(payment.PaymentId.ToString());
                item.SubItems.Add(payment.ClientName);
                item.SubItems.Add(payment.Amount.ToString("F2"));
                item.SubItems.Add(payment.PaymentDate.ToShortDateString());
                paymentsListView.Items.Add(item);
            }
        }

        private void LoadClients()
        {
            var clients = paymentController.GetAllClients();
            clientComboBox.DataSource = clients;
            clientComboBox.DisplayMember = "Name";
            clientComboBox.ValueMember = "ClientId";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var payment = new Payment
                {
                    ClientId = (int)clientComboBox.SelectedValue,
                    Amount = decimal.Parse(amountTextBox.Text),
                    PaymentDate = paymentDatePicker.Value
                };
                paymentController.AddPayment(payment);
                LoadPayments();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (!decimal.TryParse(amountTextBox.Text, out decimal amount) || amount <= 0)
            {
                errorProvider.SetError(amountTextBox, "Введіть коректну суму.");
                isValid = false;
            }
            return isValid;
        }

        private void ClearInputs()
        {
            amountTextBox.Clear();
            paymentDatePicker.Value = DateTime.Now;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (paymentsListView.SelectedItems.Count > 0)
            {
                int paymentId = int.Parse(paymentsListView.SelectedItems[0].SubItems[0].Text);
                paymentController.DeletePayment(paymentId);
                LoadPayments();
            }
        }

        private void PaymentsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Додатково: можна реалізувати відображення деталей платежу при виборі зі списку
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}