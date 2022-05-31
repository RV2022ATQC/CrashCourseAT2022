﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NLog;
using RestSharp;
using Newtonsoft.Json;

namespace RestAPI
{
    [TestFixture]
    [Parallelizable]
    internal class RestAPI
    {
        public Logger log = LogManager.GetCurrentClassLogger(); // for NLog
        private string JsonToken;
        private string cart_id;

        [Test, Order(1)]
        public void VerifyLogin()
        {
            //Arrange
            // enter your token from adminpanel bitnami
            string token_str = "hld6KM80jL5qlPzAxylp7rEzSGYKpf5hlDKhkGf17Sfyp8sUF0Rgj5MxynIbHi65vKx4sodqtGIurzDD0eg12FJJd0xz4dUOHpbGIvruRBe6SWCaD7w8OcJg6orBu2OUWKOgJjxvbugaPUA8VItSqsZubVuUYuw6h2FZi6Uh08tAWculbRoG32YB8WhFAI0NGJCfKGcFwsoUjfvr5N3uW7wgvkGmaDpvqaXE5lRcIlqb7HgKSw7B4a1kXsGsFm3b";
            log.Info("Start VerifyLogin test");
            // edit adress api/login
            var client = new RestClient("http://127.0.0.1/opencart/index.php?route=api/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("username", "Default");
            request.AddHeader("key", "j0M724bQvkcrVst6XJfafMfzNShlBx0W5PGnh2WkBy4sxPrpCk3hSqA2xAm2AHPZXynNAQEPJcOHgdPTuLSZdM1Il4wZ6vgk6Fvye0i5jSNEFIFk5s7tmKIMSItCeyYM2kLEMqaLe5mSgKOyIRTaGZq4TdPd44DleW2Q3qqfEW3jean6FbsPaCSbQeQWRqMXL5bmNWb4oFWufPMkozLdVofXUU3pY2lEZc32p6Tta1HzPUoD0APR4fCRGksv8RK6");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");
            request.AddParameter("username", "Default");
            request.AddParameter("key", token_str);

            //Act
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);

            JsonToken = data.api_token;
            Console.WriteLine(data.api_token);
            log.Info("Api_token"+ data.api_token);

            //Assert
            Assert.IsNotEmpty(JsonToken);
        }

        [Test, Order(2)]
        public void AddIPhoneInCart()
        {
            //Arrange
            log.Info("Start AddIPhoneInCart");
            string url = "http://127.0.0.1/opencart/index.php?route=api/cart/add&api_token=" + JsonToken; ;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("product_id", "40");
            request.AddParameter("quantuty", "1");

            //Act
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            log.Info(response.Content);

            //Assert
            Assert.True(response.Content.Contains("Success"));
        }

        [Test, Order(3)]
        public void VerifyAddIPoneInCartFromAPI()
        {
            //Arrange
            string ExpectedValue = "iPhone";
            string url = "http://127.0.0.1/opencart/index.php?route=api/cart/products/&api_token=" + JsonToken; ;

            log.Info("Start VerifyAddIPoneInCartFromAPI");
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");

            //Act
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);
            cart_id = data.products[0].cart_id;
            string ActualValue = data.products[0].name;
            log.Info(response.Content);

            //Assert
            Assert.AreEqual(ActualValue, ExpectedValue);
        }

        [Test, Order(4)]
        public void  DeleteItemsFromCart()
        {
            //Arrange
            string url = "http://127.0.0.1/opencart/index.php?route=api/cart/remove&=4&api_token=" + JsonToken; ;

            log.Info("Start DeleteItemsFromCart");
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("key", cart_id);

            //Act
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            log.Info(response.Content);

            //Assert
            Assert.True(response.Content.Contains("Success"));
        }

        [Test, Order(5)]
        public void VerifyEmptyCartAfterDeleteItem()
        {
            //Arrange
            string url = "http://127.0.0.1/opencart/index.php?route=api/cart/products/&api_token=" + JsonToken; ;

            log.Info("Start ViewItemsInCartAfterDelete");
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");

            //Act
            IRestResponse response = client.Execute(request);

            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);
            Console.WriteLine(response.Content);
            log.Info(response.Content);

            //Assert
            Assert.IsEmpty(data.products);

        }
    }
}
