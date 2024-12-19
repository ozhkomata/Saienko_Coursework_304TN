using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InternetProviderMenu.Controllers;

namespace InternetProviderMenu
{
    public partial class ConnectionHistoryForm : Form
    {
        private ConnectionHistoryController historyController;
        private ErrorProvider errorProvider;

        public ConnectionHistoryForm()
        {
            InitializeComponent();
            historyController = new ConnectionHistoryController();
            errorProvider = new ErrorProvider();
            ApplyCustomStyles();
            LoadConnectionHistories();
            InitializeEvents();
            LoadClients();
        }

        private void ApplyCustomStyles()
        {
            CustomStyles.StyleForm(this);
            CustomStyles.StyleButton(addButton);
            CustomStyles.StyleButton(deleteButton);
            CustomStyles.StyleButton(backButton);
            CustomStyles.StyleListView(historyListView);
            CustomStyles.StyleComboBox(clientComboBox);
            CustomStyles.StyleLabel(clientLabel);
            CustomStyles.StyleLabel(startDateLabel);
            CustomStyles.StyleLabel(endDateLabel);
        }

        private void InitializeEvents()
        {
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            backButton.Click += BackButton_Click;
            historyListView.SelectedIndexChanged += HistoryListView_SelectedIndexChanged;
        }

        private void LoadConnectionHistories()
        {
            historyListView.Items.Clear();
            List<ConnectionHistory> histories = historyController.GetAllConnectionHistories();
            foreach (var history in histories)
            {
                ListViewItem item = new ListViewItem(history.HistoryId.ToString());
                item.SubItems.Add(history.ClientName);
                item.SubItems.Add(history.StartDate.ToShortDateString());
                item.SubItems.Add(history.EndDate.ToShortDateString());
                historyListView.Items.Add(item);
            }
        }

        private void LoadClients()
        {
            var clients = historyController.GetAllClients();
            clientComboBox.DataSource = clients;
            clientComboBox.DisplayMember = "Name";
            clientComboBox.ValueMember = "ClientId";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var history = new ConnectionHistory
                {
                    ClientId = (int)clientComboBox.SelectedValue,
                    StartDate = startDatePicker.Value,
                    EndDate = endDatePicker.Value
                };
                historyController.AddConnectionHistory(history);
                LoadConnectionHistories();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (startDatePicker.Value > endDatePicker.Value)
            {
                errorProvider.SetError(endDatePicker, "Дата закінчення повинна бути пізніше або рівна даті початку.");
                isValid = false;
            }
            return isValid;
        }

        private void ClearInputs()
        {
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (historyListView.SelectedItems.Count > 0)
            {
                int historyId = int.Parse(historyListView.SelectedItems[0].SubItems[0].Text);
                historyController.DeleteConnectionHistory(historyId);
                LoadConnectionHistories();
            }
        }

        private void HistoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Додатково: можна реалізувати відображення деталей запису при виборі зі списку
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}