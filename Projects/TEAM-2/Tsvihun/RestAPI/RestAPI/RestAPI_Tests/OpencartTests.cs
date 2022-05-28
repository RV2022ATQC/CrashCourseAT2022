using System;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json;



namespace RestAPI_Tests
{
    [TestFixture]
    public class OpencartTests
    {
        private readonly string apiKey = "BDXDwfcguvPuOvDs3xbxDOfvY2mZ5gkDGEWGIHj1RoHNV3VirH6Qow0INQQqY1XDjH0qKvTl5s0VhASBt1SZQW4sbRXnXGGsJCmOe1UnYLuS3VydnKbDtXwmJWzvVgfbq44gB7Xg78ojl6CF53TpMcABvKDVoNuux5A74sHjOw2mn0QBjWCFFFORTPWvj6v4UFxwQnMiIuZGv4sjPX46hEmHqmOVFcBturQWDMJYXAoxVWnHuNJS31cVRLLo1VFv";
        string baseUrl = "http://localhost/shop/";
        string JsonToken;
        int cartId;

        [SetUp]
        public void Setup()
        {
        }


        [Test, Order(1)]
        public void Opencart_CheckLogin()
        {
            Console.WriteLine("Check API login to Opencart. Get token.");

            var client = new RestClient($"{baseUrl}index.php?route=api/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            //request.AddHeader("username", "Default");
            //request.AddHeader("key", "j0M724bQvkcrVst6XJfafMfzNShlBx0W5PGnh2WkBy4sxPrpCk3hSqA2xAm2AHPZXynNAQEPJcOHgdPTuLSZdM1Il4wZ6vgk6Fvye0i5jSNEFIFk5s7tmKIMSItCeyYM2kLEMqaLe5mSgKOyIRTaGZq4TdPd44DleW2Q3qqfEW3jean6FbsPaCSbQeQWRqMXL5bmNWb4oFWufPMkozLdVofXUU3pY2lEZc32p6Tta1HzPUoD0APR4fCRGksv8RK6");
            //request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", "Default");
            request.AddParameter("key", apiKey);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);

            JsonToken = data.api_token;
        }

        [Test, Order(2)]
        public void Opencart_AddProductToCart()
        {
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/add&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("product_id", "48");
            request.AddParameter("quantity", "20");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            Assert.That(response.Content.Contains("Success"));
        }

        [Test, Order(3)]
        public void Opencart_GetCartContent()
        {
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/products/&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            IRestResponse response = client.Execute(request);

            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);

            cartId = data.products[0].cart_id;
            Console.WriteLine($"Cart #{cartId} content:\n{source}");
            Assert.That(!source.Contains("Warning: You do not have permission to access the API!"));
        }

        [Test, Order(4)]
        public void Opencart_ChangeCart()
        {
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/edit&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("key", cartId);
            request.AddParameter("quantity", "10");
            IRestResponse response = client.Execute(request);
            
            Console.WriteLine($"{response.Content}\nCartId = {cartId}");

            //Assert.That(response.Content.Contains("Success"));
        }







        // [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}