using NUnit.Framework;
using RestSharp;
using System;



namespace RestAPI_Tests
{
    [TestFixture]
    public class OpencartTests
    {
        string baseUrl = "http://localhost/shop/";
        [SetUp]
        public void Setup()
        {
           
        }


        [Test]
        public void Opencart_CheckLogin()
        {
            var client = new RestClient($"{baseUrl}index.php?route=api/login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("username", "Default");
            request.AddHeader("key", "j0M724bQvkcrVst6XJfafMfzNShlBx0W5PGnh2WkBy4sxPrpCk3hSqA2xAm2AHPZXynNAQEPJcOHgdPTuLSZdM1Il4wZ6vgk6Fvye0i5jSNEFIFk5s7tmKIMSItCeyYM2kLEMqaLe5mSgKOyIRTaGZq4TdPd44DleW2Q3qqfEW3jean6FbsPaCSbQeQWRqMXL5bmNWb4oFWufPMkozLdVofXUU3pY2lEZc32p6Tta1HzPUoD0APR4fCRGksv8RK6");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", "Default");
            request.AddParameter("key", "BDXDwfcguvPuOvDs3xbxDOfvY2mZ5gkDGEWGIHj1RoHNV3VirH6Qow0INQQqY1XDjH0qKvTl5s0VhASBt1SZQW4sbRXnXGGsJCmOe1UnYLuS3VydnKbDtXwmJWzvVgfbq44gB7Xg78ojl6CF53TpMcABvKDVoNuux5A74sHjOw2mn0QBjWCFFFORTPWvj6v4UFxwQnMiIuZGv4sjPX46hEmHqmOVFcBturQWDMJYXAoxVWnHuNJS31cVRLLo1VFv");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }













        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}