using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NLog;
using RestSharp;
using System.Runtime.Serialization;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using System.IO;

using System.Xml.Serialization;
using System.Data.Common;
using MySql.Data.MySqlClient;
using crashCourse2022.Tools;
//using NUnit.Allure.Core;
namespace RvcrashCourse2022
{
    [TestFixture]
    [Parallelizable]
    public class RestTest
    {
        public Logger log = LogManager.GetCurrentClassLogger(); // for NLog
        private static string JsonToken;


        [OneTimeSetUp]
        public void VerifyLogin()
        {
            log.Info("Start VerifyLogin test");
            var client = new RestClient("http://127.0.0.1/opencart/index.php?route=api/login");
            //client.
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            // request.AddHeader("username", "Default");
            //  request.AddHeader("key", "lqGZVBKPYUKKJBEHPJc8TxQgH2qNsSZNNqJlTHhJY3HsRSz10YsAMw3c5BX6Xaf0xiPFeP2Z5BrMvis73iKQN7gryGvHFlrMHpcanSmfeqd0cAQTsPdXEctjhTGaxEpVXFE0AcjXYiCKuMvBOkIEVfC4icqhkETDzTNjY5nvE2egYTTvKuuVVeFyTeZrgeR5wMlgCaCmTs5lXQjMVUvUPGuIgkjpaGavRJmww5hPTGaFcrgqfRFjwrgrKMhf25yv");
            //      request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            //      request.AddHeader("Cookie", "OCSESSID=bf91ec90aba413c4745cae7240; currency=USD; language=en-gb");
            request.AddParameter("username", "Default");
            request.AddParameter("key", "5IROeQY5CpAOsSWWz7sjHYJmAapihJwvSbBMl0aHJJU4fz1Lm37SsRK83o4XJu2Zu0oOp3kCwlmTu2ilNjN6R6YGUijy7jF3048wPEytZjNKZPujUde5VBapJYWmyS1AFDFaDR6rMQLNCVbAQJbk2IRBnQEHdJl5tpn5WsmDt6xkTiXabkHIj5mZl45P3Ob7o1ST6ymwCsMHcsF4Kjxpe2yHFWOSzsHKohRswzmKENAW60yFAgL2zw4CfwxKYDmU");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);

            JsonToken = data.api_token;
            Console.WriteLine("api_token = " + data.api_token);
        }
        
        [Test]
        public void ExampleFromPostman_checkOpencartLogin()
        {
            var client = new RestClient("http://127.0.0.1/opencart/index.php?route=api/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Cookie", "OCSESSID=a5a0059be56cde184d5e2d4546; currency=USD; language=en-gb");
            request.AddParameter("username", "Default");
            request.AddParameter("key", "OnWWxLrYKYGZ75Qjv3262n2ZBZFJM4PfKZr1n4lZ2WtLFWNisIy21uzBGoIQJ8sI6D5IkaEooAPCQkNhN130i0JMlz43KdsbXtP6kF2Nbl4wSDxjaPu3l0IolVCbUSyJQ26TPZ6RwF1hsgJvEo2dtUxdhTrxQbZ4RzVO1TnXMnt0impxJjJ4uALYjsHVaEat7dYSWUFOhmsNH0HHa1fRyL7wdVpOpIgzycQFpKySPt4aQCErhNeLLp55aXjq5RWB");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.StatusCode+ "  " + response.Content);
        }

        [Test]
        public void FromPostmanPetstor_AddNewPet()
        {
            var client = new RestClient("https://petstore.swagger.io/v2/pet");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");

            var body = @"{  ""id"": 111333, 
                            ""category"": { ""id"": 0, ""name"": ""Korzhyk"" }, 
                            ""name"": ""doggie"", 
                            ""photoUrls"": [  ""string""  ], 
                            ""tags"": [   { ""id"": 0, ""name"": ""string"" } ],
                            ""status"": ""available""}";
            
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
            Console.WriteLine(response.Content);
        }

        [Test]
        public void VerifyItems_onTheWebPage()
        {
            log.Info("Check info mode");
            log.Debug("Check debug mode");
            string url = "http://127.0.0.1/opencart/index.php?route=product/category&path=57";
           
            var client = new RestClient(url);

            var request = new RestRequest(Method.GET);

            // Execute Request
            IRestResponse response = client.Execute(request);
            var content = response.Content;
           // Console.WriteLine("content: " + content);
            Assert.True(content.Contains("Samsung Galaxy Tab 10.1"));
         //   log.Info("content: " + content);
        }

        

      //  [Test]
     /*   public void UpdateItem()
        {
            //Given

            string url = $"http://127.0.0.1/opencart/index.php?route=api/cart/add&api_token={JsonToken}";
            var client = new RestClient(url);
            client.Timeout = -1;
            
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", "currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;

            request.AddParameter("product_id", "40");
            request.AddParameter("quantuty", "7");

            //When
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            
            //Then
            var content = response.Content;
            Assert.True(content.Contains("Success: You have modified your shopping cart!"));
        }*/
        [Test]
        public void Add_Product_Card()
        {
            var client = new RestClient("http://127.0.0.1/opencart/index.php?route=api/cart/add&api_token=b278db589966e55990a87e5697");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", "OCSESSID=5300df9f8e8185a024d8ffc288; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("product_id", "40");
            request.AddParameter("quantuty", "1");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        [Test]
        public void Get_Product_Card()
        {
            var client = new RestClient("http://127.0.0.1/opencart/index.php?route=api/cart/products/&api_token=fc2535956ea1242b7b6b63700b");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "OCSESSID=5300df9f8e8185a024d8ffc288; currency=USD; language=en-gb");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }  
        //модифікований запит - параметризували JsonToken
        [Test, Order(2)]
        public void ReadCart()
        {
            log.Info("Start");
            var client = new RestClient("http://127.0.0.1/opencart/index.php?route=api/cart/products&api_token=" + JsonToken);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        [Test]
        public void Remove_Product_Card()
        {
            var client = new RestClient("http://127.0.0.1/opencart/index.php?route=api/cart/remove&api_token=b278db589966e55990a87e5697");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("product_id", "40");
            //request.AddOrUpdateParameter("quantuty", "-1"); ;
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        [Test]
        public void ReadData1()
        {
            log.Info("Start");
            //
            // ServicePointManager.Expect100Continue = true;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //
            string url = "http://127.0.0.1/opencart/index.php?route=product/product&product_id=42";
            var client = new RestClient(url);
            //var request = new RestRequest("/orgs/dotnet/repos", Method.GET);
            var request = new RestRequest(Method.GET);
            //
            request.AddHeader("Postman-Token", "b69e2907-9b7f-48d9-864d-728250f852bd");
            request.AddHeader("Cache-Control", "no-cache");
            
            // Execute Request
            IRestResponse response = client.Execute(request);
            Console.WriteLine("IsSuccessful: " + response.IsSuccessful);
            var content = response.Content;
            Console.WriteLine("content: " + content);
            Assert.True(content.Contains(" Digital Video Interface (DVI) interface"));
            log.Info("done ");
        }

        [Test]
        public void ReadCrashCourseATWebPage()
        {
            log.Info("Start");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //
            string url = "https://github.com/RV2022ATQC/CrashCourseAT2022/";
            // Create WebClient
            using (var webClient = new WebClient())
            {
                webClient.Headers["User-Agent"] =
                    "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                    "(compatible; MSIE 6.0; Windows NT 5.1; " +
                    ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

                // get response
                var response = webClient.DownloadString(url);
                Console.WriteLine(response);
            }
            log.Info("done ");
        }
       
        [Test]
       // [Test, Category("Failed")]
        //  [Ignore("BDU34556 https://jiraticket")]
        [Category("Smoke")]
        public void ReadDatabase()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "SELECT * FROM oc_cart";

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
                            //Індекс стовпчика за імям
                            int empIdIndex = reader.GetOrdinal("cart_id"); // 0
                            //значення за індексом
                            long empId = Convert.ToInt64(reader.GetValue(empIdIndex));

                            int empQuanIndex = reader.GetOrdinal("quantity");// 2
                            string empQuan = reader.GetString(empQuanIndex);

                            Console.WriteLine("--------------------");
                            Console.WriteLine("empIdIndex:" + empIdIndex);
                            Console.WriteLine("EmpId:" + empId);
                           
                            Console.WriteLine("Quantity:" + empQuan);
                            //Console.WriteLine("MngId:" + mngId);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                // Закрити зєднання.
                conn.Close();
                // Знищити ресурс
                conn.Dispose();
            }
        }
    }
}
