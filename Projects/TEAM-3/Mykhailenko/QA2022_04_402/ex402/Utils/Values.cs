using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ex402.Utils
{
    public class Values : IDisposable
    {
        public IWebDriver driver;

        public readonly string LOGIN_ROOT = "root";
        public readonly string PASS_ROOT = "123456";

        public readonly string URL = "http://127.0.0.1/opencart/";
        public readonly string F_NAME = "user";
        public readonly string L_NAME = "user";
        public readonly string EMAIL = "user@user.com";
        public readonly string PHONE = "+380931234567";
        public readonly string PASS = "user";


        public Values()
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
