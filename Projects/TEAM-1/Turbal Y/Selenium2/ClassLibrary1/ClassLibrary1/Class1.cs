using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTests
{
    public class SeleniumSecond
    {
        private IWebDriver driver;
        private const string BASE_URL = "http://127.0.0.1/opencart/";
        //https://demo.opencart.com/

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            //Application.Get();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments(
            "start-maximized",
           "enable-automation",
            // "--headless",
            "--no-sandbox",
            // "--disable-infobars",
            //  "--disable-dev-shm-usage",
            // "--disable-browser-side-navigation",
            // "--disable-gpu",
            "--ignore-certificate-errors");
            driver = new ChromeDriver(options);
            //ChromeDriver
             driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
                     

        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Navigate().GoToUrl("//127.0.0.1/opencart/index.php?route=account/logout");
        }


        //Спрощуємо тест - виносимо налаштування драйвера і відкриття\закриття сесії у Setup\Teardown

        //Спрощуємо далі - виносимо локатори у клас Page
        [Test]
        public void LoginTest3()
        {
            // Steps    
            
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(240);
            var loginPage = new Page(driver);

            loginPage.AccauntField.Click();
            loginPage.LoginField.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(140);
            loginPage.EMailField.SendKeys("turbaly@gmail.com");
            //Thread.Sleep(1000); // For Presentation ONLY

            //loginPage.PasswordField.Clear();
            loginPage.PasswordField.SendKeys("marianta1");
            //loginPage.SignInButton.Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div/form/input")).Click();
            // Check
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            Assert.True(driver.FindElement(By.LinkText("Edit your account information")).Displayed);
            driver.Navigate().GoToUrl("//127.0.0.1/opencart/index.php?route=account/logout");
            driver.Quit();
        }

        [Test]
        public void LoginTest4()
        {
            // Steps    
            var firefoxoptions = new FirefoxOptions();
            firefoxoptions.AddAdditionalCapability("screenResTimeSpan.FromSeconds(10)olution", "1920x1080x24", true);
            //firefoxoptions.AddAdditionalCapability("name", runName, true);
            firefoxoptions.AddAdditionalCapability("enableLog", true, true);
            driver = new FirefoxDriver(firefoxoptions);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(240);
            var loginPage = new Page(driver);

            loginPage.AccauntField.Click();
            loginPage.LoginField.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(140);
            loginPage.EMailField.SendKeys("turbaly@gmail.com");
            //Thread.Sleep(1000); // For Presentation ONLY

            //loginPage.PasswordField.Clear();
            loginPage.PasswordField.SendKeys("marianta1");
            //loginPage.SignInButton.Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div/form/input")).Click();
            // Check
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            Assert.True(driver.FindElement(By.LinkText("Edit your account information")).Displayed);
        }
        //Спрощуємо далі - виносимо у клас LoginPage методи 
        //[Test]
        /*
        public void LoginTest5()
        {
            var loginPage = new Page(driver);

            // Steps
            loginPage.SetLoginInputClear("work")
                .SetPasswordInputClear("qwerty")
                .SignInButton.Click();

            // Check
            Assert.AreEqual("work", loginPage.UserNameButton.Text);
        }

        [Test]
        public void LoginTest6()
        {
            //Given
            var loginPage = new Page(driver);

            // Steps
            loginPage.successRegistratorLogin("work", "qwerty");
            //    .successRegistratorLogin(UserRepository.Get().Registered());

            // Check
            Assert.AreEqual("work", loginPage.UserNameButton.Text);
        }  
        */
    }
}