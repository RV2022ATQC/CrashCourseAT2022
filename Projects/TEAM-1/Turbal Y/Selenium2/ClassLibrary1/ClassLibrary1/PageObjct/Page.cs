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
    public class Page
    {
       public Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver;

        public IWebElement AccauntField => driver.FindElement(By.XPath("//span[contains(@class,'hidden-xs hidden-sm hidden-md') and contains(text(),'My Account')]"));

        public IWebElement LoginField => driver.FindElement(By.LinkText("Login"));
        public IWebElement EMailField => driver.FindElement(By.Id("input-email"));
        public IWebElement PasswordField => driver.FindElement(By.Id("input-password"));
        public IWebElement SignInButton => driver.FindElement(By.CssSelector(".btn.btn-primary"));
       // public IWebElement UserNameButton => driver.FindElement(By.CssSelector(".btn.btn-primary.btn-sm:not(.dropdown-toggle)"));


        public Page SetLoginInputClear(string login)
        {
            LoginField.Clear();
            LoginField.SendKeys(login);
            return this;
        }
        
        public Page SetPasswordInputClear(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            return this;
        }
        
        public Page successRegistratorLogin(string login, string password)
        {
            SetLoginInputClear(login);
            SetPasswordInputClear(password);
            SignInButton.Click();
            return this;
        }
    }
}
