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

            Console.WriteLine($"Redirected to {currentUrl}");
        }

        [Test]
        public void TestSearchProductInOpencart()
        {
            // 1.Fill in search field + Enter
            // 2.Check redirection & finding product

            // Arrange
            string searchUrl = "http://localhost/shop/index.php?route=product/search";

            // Act
            driver.Navigate().GoToUrl(_url);
            driver.FindElement(By.XPath("//*[@id='search']/input")).SendKeys("iphone" + Keys.Enter);

            // Assert
            string currentUrl = driver.Url;
            Assert.IsTrue(currentUrl.Contains(searchUrl));

            Console.WriteLine($"Redirected to page {currentUrl}");
        }

        [Test]
        public void TestAddProductToCart()
        {
            // Arrange
            string searchIphoneUrl = "http://localhost/shop/index.php?route=product/search&search=iphone";
            string buyButtonSelector = "#content > div:nth-child(8) > div > div > div:nth-child(2) > div.button-group > button:nth-child(1)";
            string messsageSelector = "#product-search > div.alert.alert-success.alert-dismissible";
            string cartButton = "#cart > button";

            // Act
            driver.Navigate().GoToUrl(searchIphoneUrl);
            driver.FindElement(By.CssSelector(buyButtonSelector)).Click();
            Thread.Sleep(1000);
            var message = driver.FindElement(By.CssSelector(messsageSelector));
            var button = driver.FindElement(By.CssSelector(cartButton));
                        
            // Assert
            Assert.IsTrue(message.Displayed);
            Assert.IsTrue(button.Text.Contains("1"));
            
            Console.WriteLine($"Message is shown: \"{message.Text}\"");
            Console.WriteLine($"Text on cart button: \"{button.Text}\"");

        }

        [Test]
        public void TestShoppingCartAvailability()
        {
            // Arrange
            string shopCartButtonSelector = "#top-links > ul > li:nth-child(4)";
            string cartUrl = "http://localhost/shop/index.php?route=checkout/cart";

            // Act
            driver.Navigate().GoToUrl(_url);
            driver.FindElement(By.CssSelector(shopCartButtonSelector)).Click();

            // Assert
            Assert.AreEqual(cartUrl, driver.Url);
            
            Console.WriteLine($"Redirected to shopping cart {driver.Url}");
        }


        [OneTimeTearDown]
        public void AfterAllTests()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}