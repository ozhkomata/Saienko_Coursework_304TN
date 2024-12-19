using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace InternetProviderMenu.Controllers
{
    public class PaymentController
    {
        public void AddPayment(Payment payment)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO payments (client_id, amount, payment_date)
                                 VALUES (@client_id, @amount, @payment_date)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@client_id", payment.ClientId);
                    cmd.Parameters.AddWithValue("@amount", payment.Amount);
                    cmd.Parameters.AddWithValue("@payment_date", payment.PaymentDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePayment(int paymentId)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string deletePayment = "DELETE FROM payments WHERE payment_id = @payment_id";
                using (var cmd = new SQLiteCommand(deletePayment, conn))
                {
                    cmd.Parameters.AddWithValue("@payment_id", paymentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Payment> GetAllPayments()
        {
            var payments = new List<Payment>();
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"SELECT p.payment_id, p.client_id, p.amount, p.payment_date, c.name
                                 FROM payments p
                                 JOIN clients c ON p.client_id = c.client_id";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        payments.Add(new Payment
                        {
                            PaymentId = reader.GetInt32(0),
                            ClientId = reader.GetInt32(1),
                            Amount = reader.GetDecimal(2),
                            PaymentDate = DateTime.Parse(reader.GetString(3)),
                            ClientName = reader.GetString(4)
                        });
                    }
                }
            }
            return payments;
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