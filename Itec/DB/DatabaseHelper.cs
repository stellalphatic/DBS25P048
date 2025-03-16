using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

 namespace Itec.DB
{
    public static class DatabaseHelper
    {
        private static string connectionString = "server=127.0.0.1;port=3307;user=root;database=itec;password=12345678900987654321;";

        //For SELECT Queries
        public static DataTable GetData(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
        }

        //For INSERT,UPDATE,DELETE Queries
        public static void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}