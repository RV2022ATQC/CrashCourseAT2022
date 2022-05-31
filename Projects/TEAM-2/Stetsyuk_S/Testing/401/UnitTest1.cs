using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _401
{
    [TestFixture]
    public class TestOpenCart
    {
        private static IWebDriver driver;
        private static string password;
        private static string email;
        private static readonly string url = "https://demo.opencart.com/";

        [OneTimeSetUp]
        public void CreateDriver()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestLogIn()
        {
            //Arrange
            password = "123456";
            email = "sofiaso.sofiasoo1@gmail.com";
            driver.Navigate().GoToUrl(url);


            //Act
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]")).Click();

            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a")).Click();

            driver.FindElement(By.CssSelector("#input-email")).SendKeys(email);

            driver.FindElement(By.CssSelector("#input-password")).SendKeys(password);

            driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div/form/input")).Click(); ;


            //Assert
            string expected = url + "index.php?route=account/account";
            string actual = driver.Url;
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}