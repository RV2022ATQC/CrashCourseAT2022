using MySql.Data.MySqlClient;

namespace ex402.Utils
{

    internal static class DataBase

    {
        private static readonly string _connString = "server=localhost; userid=root; password=123456; database=bitnami_opencart;port=3306";

        public static bool ExistUser(string _email)
        {
            using (var connection = new MySqlConnection(_connString))
            {
                string queryString = $@"SELECT email FROM oc_customer WHERE email = '{_email}'";
                var command = new MySqlCommand(queryString, connection);
                command.Connection.Open();
                var row = command.ExecuteScalar();
                if ( row is null) return false;
                else
                { 
                    if (row.ToString() == _email) return true; else return false;
                }
            }
        }

        public static bool DeleteUser(string _email)
        {
            using (var connection = new MySqlConnection(_connString))
            {
                string queryString = $@"DELETE FROM oc_customer WHERE email='{_email}'";
                var command = new MySqlCommand(queryString, connection);
                command.Connection.Open();
                int row = command.ExecuteNonQuery();
                if (row > 0) return true;
                else return false;
            }
        }

    }
}
