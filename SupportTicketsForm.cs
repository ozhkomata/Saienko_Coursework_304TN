using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InternetProviderMenu.Controllers;

namespace InternetProviderMenu
{
    public partial class SupportTicketsForm : Form
    {
        private SupportTicketController ticketController;
        private ErrorProvider errorProvider;

        public SupportTicketsForm()
        {
            InitializeComponent();
            ticketController = new SupportTicketController();
            errorProvider = new ErrorProvider();
            ApplyCustomStyles();
            LoadSupportTickets();
            InitializeEvents();
            LoadClients();
            LoadStatuses();
        }

        private void ApplyCustomStyles()
        {
            CustomStyles.StyleForm(this);
            CustomStyles.StyleButton(addButton);
            CustomStyles.StyleButton(deleteButton);
            CustomStyles.StyleButton(updateStatusButton);
            CustomStyles.StyleButton(backButton);
            CustomStyles.StyleListView(ticketsListView);
            CustomStyles.StyleComboBox(clientComboBox);
            CustomStyles.StyleComboBox(statusComboBox);
            CustomStyles.StyleTextBox(issueDescriptionTextBox);
            CustomStyles.StyleLabel(clientLabel);
            CustomStyles.StyleLabel(issueDescriptionLabel);
            CustomStyles.StyleLabel(statusLabel);
        }

        private void InitializeEvents()
        {
            addButton.Click += AddButton_Click;
            deleteButton.Click += DeleteButton_Click;
            updateStatusButton.Click += UpdateStatusButton_Click;
            backButton.Click += BackButton_Click;
            ticketsListView.SelectedIndexChanged += TicketsListView_SelectedIndexChanged;
        }

        private void LoadSupportTickets()
        {
            ticketsListView.Items.Clear();
            List<SupportTicket> tickets = ticketController.GetAllSupportTickets();
            foreach (var ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.TicketId.ToString());
                item.SubItems.Add(ticket.ClientName);
                item.SubItems.Add(ticket.IssueDescription);
                item.SubItems.Add(ticket.Status);
                item.SubItems.Add(ticket.CreatedAt.ToShortDateString());
                ticketsListView.Items.Add(item);
            }
        }

        private void LoadClients()
        {
            var clients = ticketController.GetAllClients();
            clientComboBox.DataSource = clients;
            clientComboBox.DisplayMember = "Name";
            clientComboBox.ValueMember = "ClientId";
        }

        private void LoadStatuses()
        {
            statusComboBox.Items.Clear();
            statusComboBox.Items.AddRange(new string[] { "Відкритий", "В процесі", "Закритий" });
            statusComboBox.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var ticket = new SupportTicket
                {
                    ClientId = (int)clientComboBox.SelectedValue,
                    IssueDescription = issueDescriptionTextBox.Text,
                    Status = statusComboBox.SelectedItem.ToString(),
                    CreatedAt = DateTime.Now
                };
                ticketController.AddSupportTicket(ticket);
                LoadSupportTickets();
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(issueDescriptionTextBox.Text))
            {
                errorProvider.SetError(issueDescriptionTextBox, "Введіть опис проблеми.");
                isValid = false;
            }
            return isValid;
        }

        private void ClearInputs()
        {
            issueDescriptionTextBox.Clear();
            statusComboBox.SelectedIndex = 0;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count > 0)
            {
                int ticketId = int.Parse(ticketsListView.SelectedItems[0].SubItems[0].Text);
                ticketController.DeleteSupportTicket(ticketId);
                LoadSupportTickets();
            }
        }

        private void UpdateStatusButton_Click(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count > 0)
            {
                int ticketId = int.Parse(ticketsListView.SelectedItems[0].SubItems[0].Text);
                string status = statusComboBox.SelectedItem.ToString();
                ticketController.UpdateSupportTicketStatus(ticketId, status);
                LoadSupportTickets();
            }
        }

        private void TicketsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count > 0)
            {
                var selectedItem = ticketsListView.SelectedItems[0];
                issueDescriptionTextBox.Text = selectedItem.SubItems[2].Text;
                statusComboBox.SelectedItem = selectedItem.SubItems[3].Text;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}