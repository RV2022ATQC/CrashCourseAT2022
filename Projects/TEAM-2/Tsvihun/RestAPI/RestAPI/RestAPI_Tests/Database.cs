using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using MySqlConnector;

namespace RestAPI_Tests
{
    internal class Database
    {
        private static readonly string _connectionString = "server=localhost; userid=root; database=shop";
        
        static void ShowHeaders(MySqlDataReader reader)
        {
            var columnNames = Enumerable.Range(0, reader.FieldCount)
                        .Select(reader.GetName)
                        .ToArray();
            foreach (var column in columnNames) { Console.Write($"{column}\t"); }
            Console.WriteLine();
        }

        static void ShowRows(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                var row = Enumerable.Range(0, reader.FieldCount)
                    .Select(reader.GetValue).ToArray();
                foreach (var column in row) { Console.Write($"{column}\t"); }
                Console.WriteLine();
            }
        }

        public static void ExecuteQuery(string queryString)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var command = new MySqlCommand(queryString, connection);
                command.Connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // If the answer of execute query in not empty - show column names & all rows below 
                if (reader.HasRows)
                {
                    //ShowHeaders(reader);
                    ShowRows(reader);
                }
                else { Console.WriteLine("No rows found."); }
            }
        }

        public static void Show_oc_cart()
        {            
            string show_oc_cart = $@"SELECT * FROM `oc_cart`";
            ExecuteQuery(show_oc_cart);
        }
    }
}
