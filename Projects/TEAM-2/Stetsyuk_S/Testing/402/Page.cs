using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestUI
{
    public class Page
    {
        public IWebDriver driver { get; }

        public Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement LogIn => driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]"));
        public IWebElement LogIn_button => driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a"));
        public IWebElement Email_Field => driver.FindElement(By.CssSelector("#input-email"));
        public IWebElement Password_Field => driver.FindElement(By.CssSelector("#input-password"));
        public IWebElement SignIn_button => driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div/form/input"));

        public Page Click_LogIn()
        {
            LogIn.Click();
            LogIn_button.Click();
            return this;
        }

        public Page Enter_Data(string email, string password)
        {
            Email_Field.Click();
            Email_Field.SendKeys(email);
            Password_Field.Click();
            Password_Field.SendKeys(password);
            return this;
        }

        public Page Click_button_LogIn()
        {
            SignIn_button.Click();
            return this;
        }

        public Page GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public string CurrentUrl()
        {
            return driver.Url.ToString();
        }
    }
}
