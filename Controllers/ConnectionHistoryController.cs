using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace InternetProviderMenu.Controllers
{
    public class ConnectionHistoryController
    {
        public void AddConnectionHistory(ConnectionHistory history)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO connection_history (client_id, start_date, end_date)
                                 VALUES (@client_id, @start_date, @end_date)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@client_id", history.ClientId);
                    cmd.Parameters.AddWithValue("@start_date", history.StartDate);
                    cmd.Parameters.AddWithValue("@end_date", history.EndDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteConnectionHistory(int historyId)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string deleteHistory = "DELETE FROM connection_history WHERE history_id = @history_id";
                using (var cmd = new SQLiteCommand(deleteHistory, conn))
                {
                    cmd.Parameters.AddWithValue("@history_id", historyId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ConnectionHistory> GetAllConnectionHistories()
        {
            var histories = new List<ConnectionHistory>();
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"SELECT ch.history_id, ch.client_id, ch.start_date, ch.end_date, c.name
                                 FROM connection_history ch
                                 JOIN clients c ON ch.client_id = c.client_id";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        histories.Add(new ConnectionHistory
                        {
                            HistoryId = reader.GetInt32(0),
                            ClientId = reader.GetInt32(1),
                            StartDate = DateTime.Parse(reader.GetString(2)),
                            EndDate = DateTime.Parse(reader.GetString(3)),
                            ClientName = reader.GetString(4)
                        });
                    }
                }
            }
            return histories;
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