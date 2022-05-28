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
     
        public static void ExecuteQuery()
        {
            var queryString = $@"SELECT * FROM `oc_cart`";

            using (var connection = new MySqlConnection(_connectionString))
            {
                var command = new MySqlCommand(queryString, connection);
                command.Connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var value = reader.GetString(3);    // This column(session_id) is token
                        Console.WriteLine(value);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
        }

        //public static void GetFirstnameById(string userId)
        //{
        //    var queryString = $@"SELECT * FROM `oc_cart`";

        //    ExecuteQuery(queryString, "SurveyTemplate was added");
        //}
    }
}
