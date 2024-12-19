using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace InternetProviderMenu.Controllers
{
    public class SupportTicketController
    {
        public void AddSupportTicket(SupportTicket ticket)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO support_tickets (client_id, issue_description, status, created_at)
                                 VALUES (@client_id, @issue_description, @status, @created_at)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@client_id", ticket.ClientId);
                    cmd.Parameters.AddWithValue("@issue_description", ticket.IssueDescription);
                    cmd.Parameters.AddWithValue("@status", ticket.Status);
                    cmd.Parameters.AddWithValue("@created_at", ticket.CreatedAt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSupportTicket(int ticketId)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string deleteTicket = "DELETE FROM support_tickets WHERE ticket_id = @ticket_id";
                using (var cmd = new SQLiteCommand(deleteTicket, conn))
                {
                    cmd.Parameters.AddWithValue("@ticket_id", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateSupportTicketStatus(int ticketId, string status)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string updateStatus = "UPDATE support_tickets SET status = @status WHERE ticket_id = @ticket_id";
                using (var cmd = new SQLiteCommand(updateStatus, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@ticket_id", ticketId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<SupportTicket> GetAllSupportTickets()
        {
            var tickets = new List<SupportTicket>();
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"SELECT st.ticket_id, st.client_id, st.issue_description, st.status, st.created_at, c.name
                                 FROM support_tickets st
                                 JOIN clients c ON st.client_id = c.client_id";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tickets.Add(new SupportTicket
                        {
                            TicketId = reader.GetInt32(0),
                            ClientId = reader.GetInt32(1),
                            IssueDescription = reader.GetString(2),
                            Status = reader.GetString(3),
                            CreatedAt = DateTime.Parse(reader.GetString(4)),
                            ClientName = reader.GetString(5)
                        });
                    }
                }
            }
            return tickets;
        }

        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = "SELECT client_id, name FROM clients";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client
                        {
                            ClientId = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
            return clients;
        }
    }
}