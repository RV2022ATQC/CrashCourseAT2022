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
        private static readonly string _urlLocal = "http://localhost/shop/index.php?route=account/login";
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

            string userEmail = "antront@ukr.net";
            string userPassword = "ront";
            string accountUrl = "http://localhost/shop/index.php?route=account/account";

            driver.Navigate().GoToUrl(_urlLocal);

            // Fill in email & password
            driver.FindElement(By.Id("input-email")).SendKeys(userEmail);
            driver.FindElement(By.Id("input-password")).SendKeys(userPassword);

            // Press "Login"
            driver.FindElement(By.CssSelector("#content > div > div:nth-child(2) > div > form > input")).Click();

            string currentUrl = driver.Url;

            // Check if redirected
            Assert.AreEqual(accountUrl, currentUrl);
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}