using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace Task_401_Selenium
{
    [TestFixture]

    class TestOpencart
    {
        private static readonly string _url = "http://localhost/shop/index.php";
        private static readonly string _urlLogin = "http://localhost/shop/index.php?route=account/login";
        //private static readonly string _urlExternal = "https://demo.opencart.com/index.php?route=account/login";
        
        IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestLoginToOpencart()
        {
            // 1.Fill in e-mail address
            // 2.Fill in password
            // 3.Press "Login" button
            // 4.Check redirection 


            // Arrange
            string userEmail = "antront@ukr.net";
            string userPassword = "ront";
            string accountUrl = "http://localhost/shop/index.php?route=account/account";

            // Act
            driver.Navigate().GoToUrl(_urlLogin);
            driver.FindElement(By.Id("input-email")).SendKeys(userEmail);
            driver.FindElement(By.Id("input-password")).SendKeys(userPassword);
            driver.FindElement(By.CssSelector("#content > div > div:nth-child(2) > div > form > input")).Click();

            // Assert
            string currentUrl = driver.Url;
            Assert.AreEqual(accountUrl, currentUrl);
        }

        [Test]
        public void TestSearchProductInOpencart()
        {
            // Arrange

            // Act
            driver.Navigate().GoToUrl(_url);
            driver.FindElement(By.XPath("/html/body/header/div/div/div[2]/div")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/header/div/div/div[2]/div")).SendKeys("iphone");
            Thread.Sleep(3000);

            // Assert

        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}