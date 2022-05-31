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
    public class LoginPage
    {
       public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver driver;

        public IWebElement LoginField => driver.FindElement(By.Id("login"));
        public IWebElement PasswordField =>  driver.FindElement(By.Id("password"));
        public IWebElement SignInButton => driver.FindElement(By.CssSelector(".btn.btn-primary"));
        public IWebElement UserNameButton => driver.FindElement(By.CssSelector(".btn.btn-primary.btn-sm:not(.dropdown-toggle)"));


        public LoginPage SetLoginInputClear(string login)
        {
            LoginField.Clear();
            LoginField.SendKeys(login);
            return this;
        }
        
        public LoginPage SetPasswordInputClear(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
            return this;
        }
        
        public LoginPage successRegistratorLogin(string login, string password)
        {
            SetLoginInputClear(login);
            SetPasswordInputClear(password);
            SignInButton.Click();
            return this;
        }
    }
}
