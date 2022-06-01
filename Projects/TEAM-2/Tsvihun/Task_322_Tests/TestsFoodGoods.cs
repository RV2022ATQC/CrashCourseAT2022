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

        [Test]
        public void TestGoodsToString()
        {
            // Arrange
            var good = new Goods("Cup", 40, new DateTime(2021, 09, 10), 20);
            var expected = "- - - - - General product. Cup\nQuantity: 20\nPrice: 40\nEntryDate: 9/10/2021 12:00:00 AM";

            // Act
            var actual = good.ToString();

            // Assert
            Assert.AreEqual(expected, actual, "Error: Overloaded method ToString() in class Goods works incorrectly!");
        }

        [Test]
        public void TestFoodGoodsToString()
        {
            // Arrange
            var food = new FoodGoods("Sugar", 32, new DateTime(2021, 12, 25), 400, "Kg", new DateTime(2021, 12, 11), "365");
            var expected = "- - - - - Food product.Sugar\nPrice: 32\nEntryDate: 12/25/2021 12:00:00 AM\nUnits: Kg\nQuantity: 400\nMade: 12/11/2021 12:00:00 AM\nBest before: 12/11/2022 12:00:00 AM";

            // Act
            var actual = food.ToString();

            // Assert
            Assert.AreEqual(expected, actual, "Error: Overloaded method ToString() in class FoodGoods works incorrectly!");
        }

        [Test]
        public void TestGetExpirationDays_Positive()
        {
            // Arrange
            var today = DateTime.Today;
            var food = new FoodGoods("Somefood", 30, today, 10, "Dozen", today, "21");
            var expected = 21;

            // Act
            var actual = food.GetExpirationDays();

            // Assert
            Assert.AreEqual(expected, actual, "Error: GetExpirationDays() works incorrectly!");
        }

       [Test]
        public void TestGetExpirationDays_Negative()
        {
            // Arrange
            var weekAgo = DateTime.Today.AddDays(-7);
            var expiredFood = new FoodGoods("Somefood", 30, weekAgo, 10, "Dozen", weekAgo, "1");
            var expected = -6;

            // Act
            var actual = expiredFood.GetExpirationDays();

            // Assert
            Assert.AreEqual(expected, actual, "Error: GetExpirationDays() works incorrectly for expired product!");
        }

        [Test]
        public void TestGetExpirationDays_Zero()
        {
            // Arrange
            var today = DateTime.Today;
            var food = new FoodGoods("Today food", 30, today, 10, "Dozen", today, "0");
            var expected = 0;

            // Act
            var actual = food.GetExpirationDays();

            // Assert
            Assert.AreEqual(expected, actual, "Error: GetExpirationDays() works incorrectly!");
        }
    }
}