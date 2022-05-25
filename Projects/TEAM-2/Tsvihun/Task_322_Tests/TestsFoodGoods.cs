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
        public void TestGoodsSetGetName()
        {
            // Arrange
            var good = new Goods();
            var expected = "Changed name";

            // Act
            good.Name = "Changed name";
            var actual = good.Name;
            
            // Assert
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine($"Successfully set name \"{actual}\"");
        }

        [Test]
        public void TestFoodGoodsSetGetName()
        {
            // Arrange
            var food = new FoodGoods();
            var expected = "Changed food name";

            // Act
            food.Name = "Changed food name";
            var actual = food.Name;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine($"Successfully set name \"{actual}\"");
        }
    }
}