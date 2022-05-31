using System;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestFramework.Utils
{
    public static class Values
    {
        public static IWebDriver driver;
        public static Logger log;
        public static readonly string DIR = "LOGS";

        //for MySql DB ConnectionString in DataBase.cs
        public static readonly string LOGIN_ROOT = "root";
        public static readonly string PASS_ROOT = "123456";

        //for tests
        public static readonly string URL = "http://127.0.0.1/opencart/";
        //for RestAPI
        public static readonly string TOKEN_STR = "hld6KM80jL5qlPzAxylp7rEzSGYKpf5hlDKhkGf17Sfyp8sUF0Rgj5MxynIbHi65vKx4sodqtGIurzDD0eg12FJJd0xz4dUOHpbGIvruRBe6SWCaD7w8OcJg6orBu2OUWKOgJjxvbugaPUA8VItSqsZubVuUYuw6h2FZi6Uh08tAWculbRoG32YB8WhFAI0NGJCfKGcFwsoUjfvr5N3uW7wgvkGmaDpvqaXE5lRcIlqb7HgKSw7B4a1kXsGsFm3b";


        //public static readonly string F_NAME = "user";
        //public static readonly string L_NAME = "user";
        public static readonly string EMAIL = "user@user.com";
        //public static readonly string PHONE = "+380931234567";
        public static readonly string PASS = "user";

        public static readonly string ITEM_ID = "30";
        public static readonly int WAIT_SECOND = 10;

        public static int n = 1000;
        public static bool screenshot = true;
        static Values()
        {
            log = LogManager.GetCurrentClassLogger(); // for NLog
        }

        public static void InitWebDriver ()
        {
            ChromeOptions opt1 = new ChromeOptions();
//            opt1.AddArguments("--headless");
            driver = new ChromeDriver();

            //FirefoxOptions opt2 = new FirefoxOptions();
            //opt2.AddArguments("--headless");
            //driver = new FirefoxDriver(opt2);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAIT_SECOND);
        }

        public static void ScreenShot()
        {
            string img = "./" + Values.DIR + "/"+ n.ToString() + ".png";
            ITakesScreenshot takesScreenshot = Values.driver as ITakesScreenshot;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            screenshot.SaveAsFile(img, ScreenshotImageFormat.Png);
            n++;
        }

        public static void QuitWebDriver()
        {
            driver.Quit();
        }
    }
}
