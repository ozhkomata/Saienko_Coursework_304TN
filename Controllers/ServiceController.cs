using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace InternetProviderMenu.Controllers
{
    public class ServiceController
    {
        public void AddService(Service service)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO services (service_name, description, cost)
                                 VALUES (@service_name, @description, @cost)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@service_name", service.ServiceName);
                    cmd.Parameters.AddWithValue("@description", service.Description);
                    cmd.Parameters.AddWithValue("@cost", service.Cost);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteService(int serviceId)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    // Оновлення клієнтів, які використовують цю послугу
                    string updateClients = "UPDATE clients SET service_id = NULL WHERE service_id = @service_id";
                    using (var cmd = new SQLiteCommand(updateClients, conn))
                    {
                        cmd.Transaction = transaction;
                        cmd.Parameters.AddWithValue("@service_id", serviceId);
                        cmd.ExecuteNonQuery();
                    }

                    // Видалення послуги
                    string deleteService = "DELETE FROM services WHERE service_id = @service_id";
                    using (var cmd = new SQLiteCommand(deleteService, conn))
                    {
                        cmd.Transaction = transaction;
                        cmd.Parameters.AddWithValue("@service_id", serviceId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
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