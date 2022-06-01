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
               public void TestBitnamiChrome1()
        {
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
           
            ChromeDriver driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(240);
            driver.Navigate().GoToUrl("http://localhost/opencart/");
            driver.FindElement(By.XPath("//span[contains(@class,'hidden-xs hidden-sm hidden-md') and contains(text(),'My Account')]")).Click() ;
            driver.FindElement(By.LinkText("Login")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(140);
           driver.FindElement(By.Id("input-email")).SendKeys("turbaly@gmail.com");
            driver.FindElement(By.Id("input-password")).SendKeys("marianta1");
            // driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div/form/input")).Click();
            //driver.FindElement(By.LinkText("Login")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
          Assert.True(driver.FindElement(By.LinkText("Edit your account information")).Displayed);
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(90);
            //Thread.Sleep(9000);
            driver.Quit();
        }
       



    }
}
