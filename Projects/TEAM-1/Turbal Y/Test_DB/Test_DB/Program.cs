using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Tutorial.SqlConn;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Test_DB
{
    class QueryDataExample
    {
        static void Main(string[] args)
        {
            // Получить объект Connection подключенный к DB.
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                // Закрыть соединение.
                conn.Close();
                // Уничтожить объект, освободить ресурс.
                conn.Dispose();
            }
            Console.Read();
        }

        private static void QueryEmployee(MySqlConnection conn)
        {
            string sql = "SELECT * FROM oc_banner";

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;


            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Индекс (index) столбца Emp_ID в команде SQL.
                        int empIdIndex = reader.GetOrdinal("banner_id"); // 0


                        long empId = Convert.ToInt64(reader.GetValue(0));

                        // Столбец Emp_No имеет index = 1.
                        string empNo = reader.GetString(1);
                        int empNameIndex = reader.GetOrdinal("name");// 2
                        string empName = reader.GetString(empNameIndex);

                        // Индекс (index) столбца Mng_Id в команде SQL.
                        int mngIdIndex = reader.GetOrdinal("status");

                        long? mngId = null;

                        // Проверить значение данного столбца может являться null или нет.
                        if (!reader.IsDBNull(mngIdIndex))
                        {
                            mngId = Convert.ToInt64(reader.GetValue(mngIdIndex));
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("empIdIndex:" + empIdIndex);
                        Console.WriteLine("EmpId:" + empId);
                        Console.WriteLine("EmpNo:" + empNo);
                        Console.WriteLine("EmpName:" + empName);
                        Console.WriteLine("MngId:" + mngId);
                    }
                }
            }

        }
    }

}
