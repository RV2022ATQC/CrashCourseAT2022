using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public static class Database
    {

        private static readonly string _connectionString = "server=localhost;user=root;password=123456;database=bitnami_opencart;";

        public static void ExecuteQuery(string queryString, string message = "")
        {
            var connectionString = _connectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine(message);
            }
        }

        #region SurveysNew
        public static void AddSurveyTemplate(string name, string templateJson)
        {
            var queryString = $@" INSERT INTO  surveys.tblSurveyDefinition
                        ([Name]
                        ,[Title]
                        ,[Json]
                        ,[Version]
                        ,[CreatedBy]
                        ,[CreatedDate])
                 VALUES('{name}'
                        ,'{name}'
                        ,'{templateJson}'
                        ,1
                        ,'Tester'
                        ,'06-23-1981')";

            ExecuteQuery(queryString, "SurveyTemplate was added");
        }

 


        public static bool CheckValue(string table, string column, string condition, int conditionValue, string result)
        {
        

            var queryString = $"SELECT {column} FROM {table} WHERE {condition} ='{conditionValue}';";

            var value = "";
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    value = (string)reader[column];
                }
                Console.WriteLine($"Result = {value}");

                return value.Contains(result);
            }
        }

        public static string PrepareDatabase(string scholarID, string surveyID)
        {
            var baseCustomQuestionsConfig = String.Empty;

            var queryString = $"SELECT CustomQuestionsAnswers FROM tblSurveyResult WHERE SurveyResultId =" +
                              $" (SELECT MAX(SurveyResultId) FROM tblSurveyResult WHERE ScholarID = '{scholarID}'  ) ;";

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    baseCustomQuestionsConfig = (string)reader["CustomQuestionsAnswers"];
                }

                Console.WriteLine($"baseCustomQuestionsConfig = {baseCustomQuestionsConfig}");

                return baseCustomQuestionsConfig;
            }
        }

        #endregion

        #region Funds

        public static void CleanPaymentRequests(string studentId, string fundname)
        {
            var queryClearScholarContacts = $"DELETE FROM tblPaymentTransaction WHERE FriendlyScholarID ='{studentId}';";
            ExecuteQuery(queryClearScholarContacts);

            queryClearScholarContacts = $"DELETE FROM tblPaymentRequest WHERE ScholarID ='{studentId}';";
            ExecuteQuery(queryClearScholarContacts);

            var fundId = GetFundId(fundname);
            queryClearScholarContacts = $"DELETE FROM tblxFundsRequestTypes WHERE FundId ='{fundId}';";
            ExecuteQuery(queryClearScholarContacts);

            queryClearScholarContacts = $"DELETE FROM tblxScholarFunds WHERE FundId ='{fundId}';";
            ExecuteQuery(queryClearScholarContacts);

            queryClearScholarContacts = $"DELETE FROM tblFund WHERE FundId ='{fundId}';";
            ExecuteQuery(queryClearScholarContacts);
        }

        public static int GetFundId(string fundName)
        {
            var queryString = $"SELECT FundId FROM tblFund WHERE Name='{fundName}';";

            var value = 0;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    value = (int)reader["FundId"];
                }

                Console.WriteLine($"FundId = {value}");

                return value;
            }
        }


        #endregion

 

        public static void CleanContacts(string scholarID)
        {
            var queryClearScholarContacts = $"DELETE FROM tblxScholarContact WHERE ScholarID ='{scholarID}';";
            ExecuteQuery(queryClearScholarContacts);

            var queryClearContacts = $"DELETE FROM tblContact WHERE Email = 'Tester@invalid.com';";
            ExecuteQuery(queryClearContacts, "tblContact is cleaned");
        }

        public static string GetStudentIdByFirstName(string studentName)
        {
            var queryString = $@" SELECT [ScholarID] FROM [dbo].[tblScholar]
                        WHERE FirstName = '{studentName.Split(' ')[0]}'";
            var value = 0;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    value = (int)reader["ScholarID"];
                }

                Console.WriteLine($"ScholarID = {value}");

                return value.ToString();
            }
        }

        public static string GetStudentsTaskIdByTitle(string scholarID, string title)
        {
            var queryString = $@" SELECT [TaskId] FROM [dbo].[tblTask]
                        WHERE [ScholarID]= '{scholarID}' AND [Title] = '{title}'";
            var value = 0;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    value = (int)reader["TaskId"];
                }

                return value.ToString();
            }
        }
    }
}
