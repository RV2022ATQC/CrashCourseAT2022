using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
//using TestFramework.Data.Application;
using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.Opera;

namespace Task_401_Selenium
{
    [TestFixture]

    class TestOpencart
    {
        private static readonly string _url = "http://localhost/shop/";
        //private static readonly string _url = "https://demo.opencart.com/";

        IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            //driver = GetBrowser();
            driver = GetChromeBrowser();

        }

        public IWebDriver GetBrowser()
        {
            var runName = GetType().Assembly.GetName().Name;
            var timestamp = $"{DateTime.Now:yyyyMMdd.HHmm}";

            var firefoxoptions = new FirefoxOptions();
            firefoxoptions.AddArgument("start-maximized");
            firefoxoptions.AddAdditionalCapability("name", runName, true);
            firefoxoptions.AddAdditionalCapability("videoName", $"{runName}.{timestamp}.mp4", true);
            firefoxoptions.AddAdditionalCapability("logName", $"{runName}.{timestamp}.log", true);
            firefoxoptions.AddAdditionalCapability("enableVNC", true, true);
            firefoxoptions.AddAdditionalCapability("enableVideo", true, true);
            firefoxoptions.AddAdditionalCapability("enableLog", true, true);
            firefoxoptions.AddAdditionalCapability("screenResolution", "1920x1080x24", true);

            var driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), firefoxoptions);

            return driver;
        }

        public IWebDriver GetChromeBrowser()
        {
            var runName = GetType().Assembly.GetName().Name;
            var timestamp = $"{DateTime.Now:yyyyMMdd.HHmm}";

            var capabilities = new DesiredCapabilities("Param");
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.BrowserVersion, "latest");
            var driver = new RemoteWebDriver(new Uri("http://selenoid-server:4444/wd/hub"), capabilities);

            var timespan = TimeSpan.FromMinutes(3);
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            options.AddArguments("--no-proxy-server");
            options.AddArguments("--ignore-certificate-errors");
            options.AddAdditionalCapability("name", runName, true);
            options.AddAdditionalCapability("videoName", $"{runName}.{timestamp}.mp4", true);
            options.AddAdditionalCapability("logName", $"{runName}.{timestamp}.log", true);
            options.AddAdditionalCapability("enableVNC", true, true);
            options.AddAdditionalCapability("enableVideo", true, true);
            options.AddAdditionalCapability("enableLog", true, true);
            options.AddAdditionalCapability("screenResolution", "1920x1080x24", true);

            var _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4444/wd/hub"), options);

            return _driver;
        }


        [Test]
        public void TestLoginToOpencart()
        {
            // 1.Fill in e-mail address
            // 2.Fill in password
            // 3.Press "Login" button
            // 4.Check redirection 

            // Arrange
            string _urlLogin = _url + "index.php?route=account/login";
            string userEmail = "antront@ukr.net";
            string userPassword = "ront";
            string accountUrl = _url + "index.php?route=account/account";

            // Act
            driver.Navigate().GoToUrl(_urlLogin);
            driver.FindElement(By.Id("input-email")).SendKeys(userEmail);
            driver.FindElement(By.Id("input-password")).SendKeys(userPassword);
            driver.FindElement(By.CssSelector("#content > div > div:nth-child(2) > div > form > input")).Click();

            // Assert
            string currentUrl = driver.Url;
            Console.WriteLine($"Redirected to {currentUrl}");
            Assert.AreEqual(accountUrl, currentUrl);
        }

        [Test]
        public void TestSearchProductInOpencart()
        {
            // 1.Fill in search field + Enter
            // 2.Check redirection & finding product

            // Arrange
            string searchUrl = _url + "index.php?route=product/search";

            // Act
            driver.Navigate().GoToUrl(_url);
            driver.FindElement(By.XPath("//*[@id='search']/input")).SendKeys("iphone" + Keys.Enter);

            // Assert
            string currentUrl = driver.Url;
            Console.WriteLine($"Redirected to page {currentUrl}");
            Assert.IsTrue(currentUrl.Contains(searchUrl));
        }

        [Test]
        public void TestAddProductToCart()
        {
            // Arrange
            string searchIphoneUrl = _url + "index.php?route=product/search&search=iphone";
            string buyButtonSelector = "#content > div:nth-child(8) > div > div > div:nth-child(2) > div.button-group > button:nth-child(1)";
            string messsageSelector = "#product-search > div.alert.alert-success.alert-dismissible";
            string cartButton = "#cart > button";

            // Act
            driver.Navigate().GoToUrl(searchIphoneUrl);
            driver.FindElement(By.CssSelector(buyButtonSelector)).Click();
            Thread.Sleep(1000);
            var message = driver.FindElement(By.CssSelector(messsageSelector));
            var button = driver.FindElement(By.CssSelector(cartButton));

            Console.WriteLine($"Message is shown: \"{message.Text}\"");
            Console.WriteLine($"Text on cart button: \"{button.Text}\"");

            // Assert
            Assert.IsTrue(message.Displayed);
            Assert.IsTrue(!button.Text.Contains("$0.00"));
        }

        [Test]
        public void TestShoppingCartAvailability()
        {
            // Arrange
            string shopCartButtonSelector = "#top-links > ul > li:nth-child(4)";
            string cartUrl = _url + "index.php?route=checkout/cart";

            // Act
            driver.Navigate().GoToUrl(_url);
            driver.FindElement(By.CssSelector(shopCartButtonSelector)).Click();

            // Assert
            Console.WriteLine($"Redirected to shopping cart {driver.Url}");
            Assert.AreEqual(cartUrl, driver.Url);
        }

        [Test]
        public void TestShoppingCart()
        {
            // Arrange
            string searchIphoneUrl = _url + "index.php?route=product/search&search=iphone";
            string buyButtonSelector = "#content > div:nth-child(8) > div > div > div:nth-child(2) > div.button-group > button:nth-child(1)";
            string shopCartButtonSelector = "#top-links > ul > li:nth-child(4)";
            string elementSelector = "#content > form > div > table > tbody > tr";

            // Act
            driver.Navigate().GoToUrl(searchIphoneUrl);
            driver.FindElement(By.CssSelector(buyButtonSelector)).Click();
            driver.FindElement(By.CssSelector(shopCartButtonSelector)).Click();
            var cartContent = driver.FindElement(By.CssSelector(elementSelector));

            // Assert
            Console.WriteLine($"Text in the list: \"{cartContent.Text}\"");
            Assert.IsTrue(cartContent.Text.Contains("iPhone"));
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            // Thread.Sleep(2000);
            driver.Quit();
        }
    }
}