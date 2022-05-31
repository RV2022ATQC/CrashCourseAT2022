using NUnit.Framework;
using OpenQA.Selenium;
using ex402.Utils;

namespace ex402.Pages
{
    internal class LoginPage
    {

        public string LoginUser(string _url, string _email, string _pass)
        {
            Values v = new Values();
            v.driver.Url = _url;
            IWebElement my_acc = v.driver.FindElement(By.ClassName("dropdown"));
            my_acc.Click();
            IWebElement login = v.driver.FindElement(By.LinkText("Login"));
            login.Click();
            IWebElement user = v.driver.FindElement(By.Name("email"));
            IWebElement pass = v.driver.FindElement(By.Name("password"));
            IWebElement btn = v.driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[2]/div/form/input"));
            user.Clear();
            user.SendKeys(_email);
            pass.Clear();
            pass.SendKeys(_pass);
            btn.Click();
            return v.driver.Url;
        }
    }
}
