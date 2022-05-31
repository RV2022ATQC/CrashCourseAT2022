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
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }

        [SetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("http://regres.herokuapp.com/login");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Navigate().GoToUrl("http://regres.herokuapp.com/logout");
        }

        [Test]
        public void LoginTest1()
        {
            //Given
            var driverLoginTest1 = new FirefoxDriver();
            driverLoginTest1.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverLoginTest1.Navigate().GoToUrl("http://regres.herokuapp.com/login");

            // Steps
            driverLoginTest1.FindElement(By.Id("login")).Click();
            driverLoginTest1.FindElement(By.Id("login")).Clear();
            driverLoginTest1.FindElement(By.Id("login")).SendKeys("work");
            Thread.Sleep(1000); // For Presentation ONLY
            //
            driverLoginTest1.FindElement(By.Id("password")).Click();
            driverLoginTest1.FindElement(By.Id("password")).Clear();
            driverLoginTest1.FindElement(By.Id("password")).SendKeys("qwerty");
            Thread.Sleep(1000); // For Presentation ONLY
            
            driverLoginTest1.FindElement(By.CssSelector(".btn.btn-primary")).Click();
            Thread.Sleep(1000); // For Presentation ONLY
            //
            // Check
            Assert.AreEqual("work",
                driverLoginTest1.FindElement(By.CssSelector(".btn.btn-primary.btn-sm:not(.dropdown-toggle)")).Text);
            //
            driverLoginTest1.FindElement(By.CssSelector(".btn.btn-primary.btn-sm.dropdown-toggle")).Click();
            Thread.Sleep(1000); // For Presentation ONLY
            driverLoginTest1.FindElement(By.XPath("//a[contains(@href,'/logout')]")).Click();
            Thread.Sleep(1000); // For Presentation ONLY
            
            // Check
            Assert.True(driverLoginTest1.FindElement(By.CssSelector("div.signin-container img"))
                .GetAttribute("src").Contains("ukraine_logo2.gif"));

            driverLoginTest1.Navigate().GoToUrl("http://regres.herokuapp.com/logout");
            driverLoginTest1.Quit();
        }

        //Спрощуємо тест - виносимо налаштування драйвера і відкриття\закриття сесії у Setup\Teardown
        [Test]
        public void LoginTest2()
        {
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("login")).Clear();
            driver.FindElement(By.Id("login")).SendKeys("Hello");
            Thread.Sleep(1000); // For Presentation ONLY

            // For Example, AJAX Refresh Element
            driver.Navigate().Refresh();

            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("login")).Clear();
            driver.FindElement(By.Id("login")).SendKeys("work");
            Thread.Sleep(1000); // For Presentation ONLY

            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("qwerty");
            Thread.Sleep(1000); // For Presentation ONLY
            
            driver.FindElement(By.CssSelector(".btn.btn-primary")).Click();
            Thread.Sleep(1000); // For Presentation ONLY

            // Check
            Assert.AreEqual("work",
                driver.FindElement(By.CssSelector(".btn.btn-primary.btn-sm:not(.dropdown-toggle)")).Text);

        }

        //Спрощуємо далі - виносимо локатори у клас LoginPage
        [Test]
        public void LoginTest3()
        {
            // Steps            
            var loginPage = new LoginPage(driver);
            loginPage.LoginField.Click();
            loginPage.LoginField.Clear();
            loginPage.LoginField.SendKeys("work");
            Thread.Sleep(1000); // For Presentation ONLY

            loginPage.PasswordField.Click();
            loginPage.PasswordField.Clear();
            loginPage.PasswordField.SendKeys("qwerty");

            loginPage.SignInButton.Click();

            // Check
            Assert.AreEqual("work",
                driver.FindElement(By.CssSelector(".btn.btn-primary.btn-sm:not(.dropdown-toggle)")).Text);
        }

        //Спрощуємо далі - виносимо у клас LoginPage методи для маніпуляції основими полями
        // ПАТТЕРН FluentInterface - методи класу змінюють об'єкт класу і повертають його ж
        [Test]
        public void LoginTest5()
        {            
            var loginPage = new LoginPage(driver);

            // Steps
            loginPage.SetLoginInputClear("work")
                .SetPasswordInputClear("qwerty")
                .SignInButton.Click();

            // Check
            Assert.AreEqual("work", loginPage.UserNameButton.Text);
        }

        //Наступне спрощення - в класі LoginPage створюємо єдиний метод, який може залогінити користувача
        //даний метод зможемо перевикористовувати у наступних тестах, або у Setup методах,
        //якщо нам для логіки тестів попередньо потрібно залогінитись
        [Test]
        public void LoginTest6()
        {
            //Given
            var loginPage = new LoginPage(driver);

            // Steps
            loginPage.successRegistratorLogin("work", "qwerty");
            //    .successRegistratorLogin(UserRepository.Get().Registered());

            // Check
            Assert.AreEqual("work", loginPage.UserNameButton.Text);
        }
    }
}