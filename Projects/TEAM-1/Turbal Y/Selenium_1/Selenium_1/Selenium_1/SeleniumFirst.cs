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
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Selenium_1
{
    [TestFixture]
    class SeleniumFirst
    {
        [Test]
        public void TestBitnamiLogin()
        {
             ChromeOptions options = new ChromeOptions();
           // options.AddArguments("--start-maximized");
           //  options.AddArguments("--disable-web-security");
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/guru99home");
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           // driver.FindElement(By.CssSelector("#search > input")).Clear();
           // driver.FindElement(By.CssSelector("#search > input")).SendKeys("Nokia" + Keys.Enter);
            // driver.FindElement(By.CssSelector("#search > My Account"));
            //driver.FindElement(By.CssSelector("#search > login")).SendKeys(Keys.Enter);
            // driver.FindElement(By.CssSelector("#search > E-Mail Address")).SendKeys("marianta1");
            // driver.FindElement(By.CssSelector("#search > Password")).SendKeys("marianta1" + Keys.Enter);
           // driver.FindElement(By.CssSelector("#search > input")).Clear();
           // driver.FindElement(By.CssSelector("#search > input")).SendKeys("iPhone" + Keys.Enter);
            driver.Quit();

        }
        /*
                [Test]
                public void selectDemo()

                {
                    IWebDriver m_driver = new ChromeDriver("C:\\Users\\Юрий\\Documents\\GitHub\\CrashCourseAT2022\\Projects\\TEAM-1\\Turbal Y\\Selenium_1\\Selenium_1\\Selenium_1\\bin\\Debug");
                    m_driver.Url = "http://demo.guru99.com/test/guru99home/";
                    m_driver.Manage().Window.Maximize();

                    IWebElement course = m_driver.FindElement(By.XPath("//*[@id='awf_field-91977689']"));

                    var selectTest = new SelectElement(course);
                    // Select a value from the dropdown				
                    selectTest.SelectByValue("sap-abap");
                    m_driver.Quit();


                } */
        /*
        [Test]
        public void FirstTest()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--start-maximized");
           // options.AddArguments("--no-proxy-server");
            //options.AddArguments("--no-sandbox");
            //options.AddArguments("--disable-web-security");
            options.AddArguments("--ignore-certificate-errors");
            //options.AddArguments("--disable-extensions");
            //options.AddArguments("--headless");


            //ініціалізація драйвера
            //IWebDriver driver = new ChromeDriver();
            IWebDriver driver = new ChromeDriver(options);

            //можемо ініціалізувати різні браузери

            //встановлення параметрів для Firefox
           // var firefoxoptions = new FirefoxOptions();
            //   firefoxoptions.AddAdditionalCapability("screenResTimeSpan.FromSeconds(10)olution", "1920x1080x24", true);
            //firefoxoptions.AddAdditionalCapability("name", runName, true);
            // firefoxoptions.AddAdditionalCapability("enableLog", true, true);

           // IWebDriver driver = new FirefoxDriver(firefoxoptions);
            //IWebDriver driver = new FirefoxDriver();

            //конфігурація вебдрайверу
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //відкриваємо сайт за вказаним URL
            driver.Navigate().GoToUrl("http://demo.opencart.com/");
                        //пошук елементів за різними селекторами
            //driver.FindElement(By.XPath("/html/body/header/div/div/div[2]/div/input")).Click();
            //driver.FindElement(By.XPath("//*[@id='search']/input")).Click();
           // driver.FindElement(By.Id("search")).Click();


            //driver.FindElement(By.CssSelector("#search > input")).Clear();
           // driver.FindElement(By.CssSelector("#search > input")).SendKeys("Nokia");


         //driver.FindElement(By.ClassName("input-group")).FindElement(By.CssSelector("input")).Click();

         //driver.FindElement(By.CssSelector("#search > input")).Click();

            #region Lasyinitialisation
            var SearchField = driver.FindElement(By.CssSelector("#search > input"));

            SearchField.SendKeys("Nokia");
            SearchField.Clear();

            driver.Navigate().Refresh();

            //з лінівою ініціалізацією потрібно бути обережними
            //SearchField.Clear();
            //SearchField.SendKeys("iPhone" + Keys.Enter);

            #endregion Lasyinitialisation


            //введення тексту
           driver.FindElement(By.CssSelector("#search > input")).Clear();
           driver.FindElement(By.CssSelector("#search > input")).SendKeys("iPhone" + Keys.Enter);



           // driver.FindElement(By.Id("lst-ib")).SendKeys("selenium ide" + Keys.Enter);
           // driver.FindElement(By.CssSelector("#search > input")).SendKeys("iPhone");
            //driver.FindElement(By.CssSelector("#search > input")).Submit();

           //Thread.Sleep(2000);

            #region JavaScriptExecutor 
            //-----------------------JavaScriptExecutor--------------------------------------------
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            javaScript.ExecuteScript("alert('Hello!');");
            Thread.Sleep(3000);
            driver.SwitchTo().Alert().Accept();

                   
            //----Search By JavaScript
            //IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            IWebElement actual = (IWebElement)javaScript
                .ExecuteScript("return document.getElementsByClassName('caption')[0];", new object[1] { "" });

            /*
            //----Goto Position By JavaScript.
            //IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            IWebElement position = driver.FindElement(By.CssSelector("body > footer > div > p > a"));
            javaScript.ExecuteScript("arguments[0].scrollIntoView(true);", position);

            Thread.Sleep(3000);
            */
        /*
                    #endregion JavaScriptExecutor



                    // -----------Goto Position. Use Actions class
                   // Actions action = new Actions(driver);

                   // IWebElement position = driver.FindElement(By.CssSelector("body > footer > div > p > a"));

                   // action.MoveToElement(position).Perform();
                  //  action.ClickAndHold().MoveToElement(position).Perform();

                    //Thread.Sleep(4000);


                    //Перевіряємо текст знайденого IWebElement
                    Assert.True(actual.Text.Contains("iPhone"));


                    //Є можливість робити скріншоти
                  //  ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
                  //  Screenshot screenshot = takesScreenshot.GetScreenshot();
                  //  screenshot.SaveAsFile("c:/Screenshot1.png", ScreenshotImageFormat.Png);


                    // !!!driver.Quit() потрібно виносити у teardown
                    driver.Quit();
                }

                [Test]
                public void TestDragDrop()
                {
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://mdn.github.io/dom-examples/drag-and-drop/copy-move-DataTransfer.html");

                    //   Assert.True(driver.FindElement(By.Id("newId")).Displayed);

                    IWebElement source = driver.FindElement(By.Id("src_copy"));
                    IWebElement target = driver.FindElement(By.Id("dest_copy"));

                    Actions builder = new Actions(driver);
                    builder.DragAndDrop(source, target).Perform();

                    Thread.Sleep(3000);
                    try
                    {
                        Assert.True(driver.FindElement(By.Id("newId")).Displayed);
                        Thread.Sleep(3000);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
                    Screenshot screenshot = takesScreenshot.GetScreenshot();
                    screenshot.SaveAsFile("c:/Screenshot1.png", ScreenshotImageFormat.Png);

                    driver.Quit();
                }


                [Test]
                public void TestDragDrop2()
                {

                    //параметри для Chrome
                    ChromeOptions options = new ChromeOptions();

                    options.AddArguments("--start-maximized");
                    options.AddArguments("--no-proxy-server");
                    //options.AddArguments("--no-sandbox");
                    //options.AddArguments("--disable-web-security");
                    options.AddArguments("--ignore-certificate-errors");
                    //options.AddArguments("--disable-extensions");
                    //options.AddArguments("--headless");
                    IWebDriver driver = new ChromeDriver(options);


                    driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");

                    Thread.Sleep(3000);


                    WebElement source = (WebElement)driver.FindElement(By.Id("column-a"));
                    WebElement target = (WebElement)driver.FindElement(By.Id("column-b"));



                    Actions builder = new Actions(driver);
                    builder.DragAndDrop(source, target).Perform();

                    Assert.True(source.Text == "A");



                   // builder.ClickAndHold(source).MoveToElement(target).Click(target).Release(target).Build().Perform();

                    builder.ClickAndHold(source).Build().Perform();
                    Thread.Sleep(1000);
                    builder.Click(target).Build().Perform();
                    builder.Release(target).Build().Perform();


                    builder.DragAndDropToOffset(source, 100, 300).Perform();

                   builder.ClickAndHold(target).Release(source).Build().Perform();

                    target.Click();

                    Thread.Sleep(3000);

                    Assert.True(target.Text == "A");


                    //ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;
                    //Screenshot screenshot = takesScreenshot.GetScreenshot();
                    //screenshot.SaveAsFile("c:/Screenshot1.png", ScreenshotImageFormat.Png);

                    driver.Quit();
                }*/

    }
}
