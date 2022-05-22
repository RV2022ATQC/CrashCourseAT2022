using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace ex402.Pages
{
    internal class MainPage : IDisposable
    {
        public IWebDriver driver;
        public MainPage()
        {
            //driver = new ChromeDriver();
            driver = new FirefoxDriver();
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}
