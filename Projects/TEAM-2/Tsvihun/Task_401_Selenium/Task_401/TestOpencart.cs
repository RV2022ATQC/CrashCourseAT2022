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
            driver.Navigate().GoToUrl(_urlLocal);
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}