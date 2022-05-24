using MySql.Data.MySqlClient;

namespace ex402.Utils
{
    public class DataBase

    {
        private string _connString;
        public DataBase(string _log_root, string _pass_root) 
        {
            _connString = $"server=localhost; userid={_log_root}; password={_pass_root}; database=bitnami_opencart;port=3306";
        }

        public bool ExistUser(string _email)
        {
            using (var connection = new MySqlConnection(_connString))
            {
                string queryString = $@"SELECT email FROM oc_customer WHERE email = '{_email}'";
                var command = new MySqlCommand(queryString, connection);
                command.Connection.Open();
                var row = command.ExecuteScalar();
                if ( row is null) return false;
                else return true;
            }
        }

        public bool DeleteUser(string _email)
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

        public bool InsertUser () //insert into db email = user@user.com  pass = user  do not change sql
        {
            using (var connection = new MySqlConnection(_connString))
            {
                string queryString = $@"INSERT INTO oc_customer (customer_group_id, language_id, firstname, lastname, email, telephone,  fax, password, salt, custom_field, ip, status, safe, token, code, date_added) VALUES (1, 1,'user','user','user@user.com','+380931234567','','ed4d12043152fc37048aed7c9b35516d39168dde','PolW9RfIu','','127.0.0.1',1,0,'','','2022-05-24 16:52:58')";
                var command = new MySqlCommand(queryString, connection);
                command.Connection.Open();
                int row = command.ExecuteNonQuery();
                if (row > 0) return true;
                else return false;
            }
        }
    }
}
