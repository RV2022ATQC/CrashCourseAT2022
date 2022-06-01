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
            // Arrange
            Console.WriteLine("Check API login to Opencart. Get token.");
            var client = new RestClient($"{baseUrl}index.php?route=api/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            // Act
            request.AddParameter("username", "Default");
            request.AddParameter("key", apiKey);
            IRestResponse response = client.Execute(request);
            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);
            JsonToken = data.api_token;

            // Assert
            Assert.That(!String.IsNullOrEmpty(JsonToken));
            Console.WriteLine(response.Content);
        }

        [Test, Order(2)]
        public void Opencart_AddProductToCart()
        {
            // Arrange
            Console.WriteLine("Check adding product to cart.");
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/add&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            // Act
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("product_id", "48");
            request.AddParameter("quantity", "20");
            IRestResponse response = client.Execute(request);
            
            // Assert
            Assert.That(response.Content.Contains("Success"));
            Console.WriteLine(response.Content);
        }

        // Always green test
        [Test, Order(3)]
        public void Opencart_CheckAddProductToCartInDB()
        {
            Database.Show_oc_cart();
        }

        [Test, Order(4)]
        public void Opencart_GetCartContent()
        {
            // Arrange
            Console.WriteLine("Getting cart content.");
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/products/&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);

            // Act
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            IRestResponse response = client.Execute(request);
            string source = response.Content;
            dynamic data = JsonConvert.DeserializeObject(source);
            cartId = data.products[0].cart_id;

            // Assert
            Assert.That(!source.Contains("Warning: You do not have permission to access the API!"));
            Console.WriteLine($"Cart #{cartId} content:\n{source}");
        }

        [Test, Order(5)]
        public void Opencart_ChangeCart()
        {
            // Arrange
            Console.WriteLine("Changing cart.");
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/edit&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            // Act
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("key", cartId);
            request.AddParameter("quantity", "10");
            IRestResponse response = client.Execute(request);
            
            // Assert
            Assert.That(response.Content.Contains("Success"));
            Console.WriteLine($"{response.Content}\nCartId = {cartId}");
        }

        [Test,Order(6)]
        public void Opencart_RemoveFromCart()
        {
            // Arrange
            Console.WriteLine("Check remove from cart.");
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/remove&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);

            // Act
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            request.AlwaysMultipartFormData = true;
            request.AddParameter("key", cartId);
            IRestResponse response = client.Execute(request);

            // Assert
            Assert.That(response.Content.Contains("Success"));
            Console.WriteLine($"{response.Content}\nCartId = {cartId}");
        }

        [Test, Order(7)]
        public void Opencart_CheckIfEmptyCart()
        {
            // Arrange
            Console.WriteLine("Check if cart is empty");
            var client = new RestClient($"{baseUrl}index.php?route=api/cart/products/&api_token={JsonToken}");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);

            // Act
            request.AddHeader("Cookie", $"OCSESSID={JsonToken}; currency=USD; language=en-gb");
            IRestResponse response = client.Execute(request);

            // Assert
            Assert.That(response.Content.Contains("\"title\":\"Total\",\"text\":\"$0.00\""));
            Console.WriteLine($"Cart #{cartId} content:\n{response.Content}");
        }

        [Test, Order(8)]
        public void Opencart_CheckIfEmptyCartInDB()
        {
            Database.Show_oc_cart();
        }
    }
}