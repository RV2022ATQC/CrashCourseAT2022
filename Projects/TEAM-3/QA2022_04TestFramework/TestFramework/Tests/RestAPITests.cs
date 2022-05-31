// Do not update nuget package RestSharp ver > 107
// In nuget package RestSharp ver <= 107 changes classes and interfaces

using System;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json;
using TestFramework.Utils;
using System.Collections.Generic;

namespace TestFramework.Tests
{

    // for JsonConvert.DeserializeObject<cart>
    public class option1
    {
        public string product_option_id { get; set; }
        public string product_option_value_id { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public string type { get; set; }
    }

    public class products1
    {
        public string cart_id { get; set; }
        public string product_id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public List<option1> option { get; set; }
        public string quantity { get; set; }
        public bool stock { get; set; }
        public string shipping { get; set; }
        public string price { get; set; }
        public string total { get; set; }
        public int reward { get; set; }
    }

    public class total1
    {
        public string title { get; set; }
        public string text { get; set; }
    }

    public class cart
    {
        public List<products1> products { get; set; }
        public List<string> vouchers { get; set; }
        public List<total1> totals { get; set; }
    }

    [TestFixture]
    public class RestAPITests
    {

        private string JsonToken;
        private string cart_id;

        [Test, Order(1)]
        public void APITest_1_VerifyLogin()
        {
            //Arrange
            // enter your token from adminpanel bitnami
            Values.log.Info("START TEST APITest_1_VerifyLogin");
            // edit adress api/login
            string route = "index.php?route=api/login";
            string url = Values.URL + route;

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("username", "Default");
            request.AddHeader("key", "j0M724bQvkcrVst6XJfafMfzNShlBx0W5PGnh2WkBy4sxPrpCk3hSqA2xAm2AHPZXynNAQEPJcOHgdPTuLSZdM1Il4wZ6vgk6Fvye0i5jSNEFIFk5s7tmKIMSItCeyYM2kLEMqaLe5mSgKOyIRTaGZq4TdPd44DleW2Q3qqfEW3jean6FbsPaCSbQeQWRqMXL5bmNWb4oFWufPMkozLdVofXUU3pY2lEZc32p6Tta1HzPUoD0APR4fCRGksv8RK6");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");
            request.AddParameter("username", "Default");
            request.AddParameter("key", Values.TOKEN_STR);

            //Act
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);
            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);

            JsonToken = data.api_token;
            Values.log.Info("RESULT TEST Api_token = " + data.api_token + "\n");

            //Assert
            Assert.IsNotEmpty(JsonToken);
        }

        [Test, Order(2)]
        public void APITest_2_AddItemInCart()
        {
            //Arrange
            Values.log.Info("START TEST APITest_2_AddItemInCart");
            string route = "index.php?route=api/cart/add&api_token=";
            string url = Values.URL + route + JsonToken;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("product_id", Values.ITEM_ID);
            request.AddParameter("quantuty", "1");
            request.AddParameter("option[226]", "16");

            //Act
            IRestResponse response = client.Execute(request);
            Values.log.Info("RESULT TEST response.Content = " + response.Content + "\n");

            //Assert
            Assert.True(response.Content.Contains("Success"));
        }

        [Test, Order(3)]
        public void APITest_3_VerifyAddItemInCartFromAPI()
        {
            //Arrange
            string ExpectedValue = "Canon EOS 5D";
            string route = "index.php?route=api/cart/products/&api_token=";
            string url = Values.URL + route + JsonToken;
            Values.log.Info("START TEST APITest_3_VerifyAddItemInCartFromAPI");
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");

            //Act
            IRestResponse response = client.Execute(request);
            string source = response.Content;
            var data = JsonConvert.DeserializeObject<cart>(source);
            string ActualValue = FindProductFromCart(data,ExpectedValue);
            try { cart_id = data.products[0].cart_id; }
            catch { cart_id = "0"; }
            Values.log.Info("RESULT TEST response.Content = " + response.Content + "\n");

            //Assert
            Assert.AreEqual(ActualValue, ExpectedValue);
        }

        [Test, Order(4)]
        public void APITest_4_DeleteItemsFromCart()
        {
            //Arrange
            string route = "index.php?route=api/cart/remove&=4&api_token=";
            string url = Values.URL + route + JsonToken;
            Values.log.Info("START TEST APITest_4_DeleteItemsFromCart");
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("key", cart_id);

            //Act
            IRestResponse response = client.Execute(request);
            Values.log.Info("RESULT TEST response.Content = " + response.Content + "\n");

            //Assert
            Assert.True(response.Content.Contains("Success"));
        }

        [Test, Order(5)]
        public void APITest_5_VerifyEmptyCartAfterDeleteItem()
        {
            //Arrange
            string route = "index.php?route=api/cart/products/&api_token=";
            string url = Values.URL + route + JsonToken;
            Values.log.Info("START TEST APITest_5_VerifyEmptyCartAfterDeleteItem");
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "OCSESSID=f778808d6c629abadee364daba; currency=USD; language=en-gb");

            //Act
            IRestResponse response = client.Execute(request);

            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);
            Values.log.Info("RESULT TEST response.Content = " + response.Content + "\n");

            //Assert
            Assert.IsEmpty(data.products);
        }

        public string FindProductFromCart(cart _cart, string _find_name)
        {
            foreach (var product in _cart.products) { if (product.name.Contains(_find_name)) return product.name; }
            return "";
        }
    }
}
