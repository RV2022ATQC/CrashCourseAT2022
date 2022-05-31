using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

//До попереднього завдання додаємо клас Page і виносимо 
//у нього усі UI елементи. Дописуємо аналогічний тест, 
//але для виконання з Firefox. Реалізовуємо паралельне 
//виконання двох тестів

namespace TestUI
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Tests
    {
        private static IWebDriver Chromedriver;
        private static IWebDriver FireFoxdriver;
        private static string password;
        private static string email;
        private static readonly string url = "https://demo.opencart.com/";

        [OneTimeSetUp]
        public void CreateDriver()
        {
            Chromedriver = new ChromeDriver();
            FireFoxdriver = new FirefoxDriver();

            password = "123456";
            email = "sofiaso.sofiasoo1@gmail.com";
        }

        [Test]
        public void TestLogIn_Chrome()
        {
            //Arrange
            password = "123456";
            email = "sofiaso.sofiasoo1@gmail.com";

            Page page = new Page(Chromedriver);

            page.GoToUrl(url);


            //Act

            page.Click_LogIn()
                .Enter_Data(email, password)
                .Click_button_LogIn();

            //Assert
            string expected = url + "index.php?route=account/account";
            string actual = page.CurrentUrl();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestLogIn_FireFox()
        {
            //Arrange
            password = "123456";
            email = "sofiaso.sofiasoo1@gmail.com";

            Page page = new Page(FireFoxdriver);

            page.GoToUrl(url);


            //Act

            page.Click_LogIn()
                .Enter_Data(email, password)
                .Click_button_LogIn();

            //Assert
            string expected = url + "index.php?route=account/account";
            string actual = page.CurrentUrl();
            Assert.AreEqual(expected, actual);
        }

        [OneTimeTearDown]
        public void Close()
        {
            Chromedriver.Quit();
            FireFoxdriver.Quit();
        }
    }
}