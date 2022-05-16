using MySql.Data.MySqlClient;
using System;
//using System.Data.SqlClient;

namespace RestAPI
{
    public static class Database
    {

        private static readonly string _connectionString = "server=localhost; userid=root; password=123456; database=bitnami_opencart";

        public static string ExecuteQuery(string queryString)
        {
            try
            {
                // Open the database
                using var databaseConnection = new MySqlConnection(_connectionString);
                databaseConnection.Open();

                //      queryString = "SELECT `firstname` FROM `oc_customer` WHERE `customer_id` = 2";
                var command = new MySqlCommand(queryString, databaseConnection);

                // Execute the query
                var result = command.ExecuteScalar().ToString();
                Console.WriteLine($"Result = {result}");
              //  throw new Exception("Test exception");
                return result;
            }
            catch (Exception ex)
            {
                // Show any error message.
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public static string GetFirstnameById(string userId)
        {
            // var queryString = "SELECT `firstname` FROM `oc_customer` WHERE `customer_id` = 2";
            var queryString = $@"SELECT `firstname` FROM `oc_customer` WHERE `customer_id` = {userId}";

            return ExecuteQuery(queryString);
        }

    }
}