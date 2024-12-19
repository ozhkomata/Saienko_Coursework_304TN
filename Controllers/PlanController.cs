using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace InternetProviderMenu.Controllers
{
    public class PlanController
    {
        public void AddPlan(Plan plan)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO plans (plan_name, price, speed)
                                 VALUES (@plan_name, @price, @speed)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@plan_name", plan.PlanName);
                    cmd.Parameters.AddWithValue("@price", plan.Price);
                    cmd.Parameters.AddWithValue("@speed", plan.Speed);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePlan(int planId)
        {
            using (var conn = DB.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    // Оновлення клієнтів, які використовують цей план
                    string updateClients = "UPDATE clients SET plan_id = NULL WHERE plan_id = @plan_id";
                    using (var cmd = new SQLiteCommand(updateClients, conn))
                    {
                        cmd.Transaction = transaction;
                        cmd.Parameters.AddWithValue("@plan_id", planId);
                        cmd.ExecuteNonQuery();
                    }

                    // Видалення плану
                    string deletePlan = "DELETE FROM plans WHERE plan_id = @plan_id";
                    using (var cmd = new SQLiteCommand(deletePlan, conn))
                    {
                        cmd.Transaction = transaction;
                        cmd.Parameters.AddWithValue("@plan_id", planId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
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
    }
}