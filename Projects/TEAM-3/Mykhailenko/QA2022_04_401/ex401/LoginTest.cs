using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ex401
{
    public class LoginTests
    {
        IWebDriver driver;
        string user_name;
        string user_pass;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            user_name = "admin";
            user_pass = "123456";
        }

        [Test]
        public void Login()
        {
            string expected_str = "NAVIGATION";

            driver.Url = "https://localhost/opencart/admin/index.php?route=common/login";
            IWebElement user = driver.FindElement(By.Id("input-username"));
            IWebElement pass = driver.FindElement(By.Id("input-password"));
            IWebElement btn = driver.FindElement(By.ClassName("btn-primary"));
            user.SendKeys(user_name);
            pass.SendKeys(user_pass);
            btn.Click();
            IWebElement admin_nav = driver.FindElement(By.Id("navigation"));
            string actual_str = admin_nav.Text;

            Assert.AreEqual(expected_str,actual_str);
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}