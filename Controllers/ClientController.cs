using System;
using System.Collections.Generic;
using System.Data.SQLite;
using InternetProviderMenu.Controllers;

namespace InternetProviderMenu.Controllers
{
    public class ClientController
    {
        public void AddClient(Client client)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO clients (name, address, email, phone, plan_id, service_id)
                                 VALUES (@name, @address, @email, @phone, @plan_id, @service_id)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", client.Name);
                    cmd.Parameters.AddWithValue("@address", client.Address);
                    cmd.Parameters.AddWithValue("@email", client.Email);
                    cmd.Parameters.AddWithValue("@phone", client.Phone);
                    cmd.Parameters.AddWithValue("@plan_id", client.PlanId);
                    cmd.Parameters.AddWithValue("@service_id", (object)client.ServiceId ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteClient(int clientId)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    string deletePayments = "DELETE FROM payments WHERE client_id = @client_id";
                    string deleteHistory = "DELETE FROM connection_history WHERE client_id = @client_id";
                    string deleteTickets = "DELETE FROM support_tickets WHERE client_id = @client_id";
                    string deleteClient = "DELETE FROM clients WHERE client_id = @client_id";

                    using (var cmd = new SQLiteCommand(conn))
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = deletePayments;
                        cmd.Parameters.AddWithValue("@client_id", clientId);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = deleteHistory;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = deleteTickets;
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = deleteClient;
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"SELECT c.*, p.plan_name, s.service_name
                                 FROM clients c
                                 JOIN plans p ON c.plan_id = p.plan_id
                                 LEFT JOIN services s ON c.service_id = s.service_id";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client
                        {
                            ClientId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Email = reader.GetString(3),
                            Phone = reader.GetString(4),
                            PlanId = reader.GetInt32(5),
                            ServiceId = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6),
                            PlanName = reader.GetString(7),
                            ServiceName = reader.IsDBNull(8) ? "" : reader.GetString(8)
                        });
                    }
                }
            }
            return clients;
        }

        public List<Plan> GetAllPlans()
        {
            var plans = new List<Plan>();
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM plans";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        plans.Add(new Plan
                        {
                            PlanId = reader.GetInt32(0),
                            PlanName = reader.GetString(1),
                            Price = reader.GetDecimal(2),
                            Speed = reader.GetString(3)
                        });
                    }
                }
            }
            return plans;
        }

        public List<Service> GetAllServices()
        {
            var services = new List<Service>();
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM services";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        services.Add(new Service
                        {
                            ServiceId = reader.GetInt32(0),
                            ServiceName = reader.GetString(1),
                            Description = reader.GetString(2),
                            Cost = reader.GetDecimal(3)
                        });
                    }
                }
            }
            return services;
        }
    }
}