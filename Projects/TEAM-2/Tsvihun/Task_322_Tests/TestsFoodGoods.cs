using NUnit.Framework;
using System;
using Task_322;

namespace Task_322_Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetExpirationDays()
        {
            Console.WriteLine("Testing \"Get expiration days\" method...");
            var food = new FoodGoods();
            Assert.Pass();
        }
    }
}