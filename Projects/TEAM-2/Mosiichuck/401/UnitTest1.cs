<<<<<<< Updated upstream
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _401
{
    [TestFixture]
    //Створіть Selenium-test, який перевіряє можливість залогінитись до сайту (бажано OpenCart)
    public class TestOpenCart
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public void CreateDriver()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestLogin()
        {
            string password = "12345678";
            string email = "desares526@gmail.com";
            string url = "https://demo.opencart.com/index.php?route=account/login";

            driver.Navigate().GoToUrl(url);

            driver.FindElement(By.Id("input-email")).SendKeys(email);
            driver.FindElement(By.Id("input-password")).SendKeys(password);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div/form/input")).Click(); 

            string expected = "https://demo.opencart.com/index.php?route=account/account";
            string actual = driver.Url;
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
=======
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _401
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
>>>>>>> Stashed changes
        }
    }
}