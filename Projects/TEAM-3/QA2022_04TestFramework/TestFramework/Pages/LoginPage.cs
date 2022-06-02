using NUnit.Framework;
using OpenQA.Selenium;
using TestFramework.Utils;
using System.Threading;

namespace TestFramework.Pages
{
    internal class LoginPage
    {
        IWebElement my_acc;
        IWebElement user;
        IWebElement pass;
        IWebElement btn;

        public string LoginUser(string _url, string _email, string _pass)
        {
            Values.driver.Url = _url;
            if (Values.screenshot) Values.ScreenShot();
            my_acc = Values.driver.FindElement(By.ClassName("caret"));
            my_acc.Click();
            if (Values.screenshot) Values.ScreenShot();
            IWebElement login = Values.driver.FindElement(By.LinkText("Login"));
            login.Click();
            if (Values.screenshot) Values.ScreenShot();
            user = Values.driver.FindElement(By.Name("email"));
            pass = Values.driver.FindElement(By.Name("password"));
            btn = Values.driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[2]/div/form/input"));
            user.Clear();
            user.SendKeys(_email);
            pass.Clear();
            pass.SendKeys(_pass);
            if (Values.screenshot) Values.ScreenShot();
            btn.Click();
            if (Values.screenshot) Values.ScreenShot();
            return Values.driver.Url;
        }
    }
}
