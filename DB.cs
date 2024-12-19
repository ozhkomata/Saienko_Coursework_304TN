using System;
using System.Data.SQLite;
using System.IO;

namespace InternetProviderMenu
{
    public static class DB
    {
        private static readonly string dbFile = "InternetProvider.db";
        private static readonly string connectionString = $"Data Source={dbFile};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                CreateTables();
            }
            return new SQLiteConnection(connectionString);
        }

        private static void CreateTables()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS plans (
    plan_id INTEGER PRIMARY KEY AUTOINCREMENT,
    plan_name TEXT,
    price DECIMAL(10,2),
    speed TEXT
);

CREATE TABLE IF NOT EXISTS services (
    service_id INTEGER PRIMARY KEY AUTOINCREMENT,
    service_name TEXT,
    description TEXT,
    cost DECIMAL(10,2)
);

CREATE TABLE IF NOT EXISTS clients (
    client_id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT,
    address TEXT,
    email TEXT,
    phone TEXT,
    plan_id INTEGER NOT NULL,
    service_id INTEGER,
    FOREIGN KEY(plan_id) REFERENCES plans(plan_id),
    FOREIGN KEY(service_id) REFERENCES services(service_id)
);

CREATE TABLE IF NOT EXISTS payments (
    payment_id INTEGER PRIMARY KEY AUTOINCREMENT,
    client_id INTEGER,
    amount DECIMAL(10,2),
    payment_date DATETIME,
    FOREIGN KEY(client_id) REFERENCES clients(client_id)
);

CREATE TABLE IF NOT EXISTS connection_history (
    history_id INTEGER PRIMARY KEY AUTOINCREMENT,
    client_id INTEGER,
    start_date DATE,
    end_date DATE,
    FOREIGN KEY(client_id) REFERENCES clients(client_id)
);

CREATE TABLE IF NOT EXISTS support_tickets (
    ticket_id INTEGER PRIMARY KEY AUTOINCREMENT,
    client_id INTEGER,
    issue_description TEXT,
    status TEXT,
    created_at DATETIME,
    FOREIGN KEY(client_id) REFERENCES clients(client_id)
);
";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}