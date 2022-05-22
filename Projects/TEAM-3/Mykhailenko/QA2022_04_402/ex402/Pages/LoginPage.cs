using NUnit.Framework;
using OpenQA.Selenium;


namespace ex402.Pages
{
    internal class LoginPage : MainPage
    {

        public void LoginUser(string _url, string _email, string _pass)
        {
            driver.Url = _url;
            IWebElement my_acc = driver.FindElement(By.ClassName("dropdown"));
            my_acc.Click();
            IWebElement login = driver.FindElement(By.LinkText("Login"));
            login.Click();
            IWebElement user = driver.FindElement(By.Name("email"));
            IWebElement pass = driver.FindElement(By.Name("password"));
            IWebElement btn = driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[2]/div/form/input"));
            user.Clear();
            user.SendKeys(_email);
            pass.Clear();
            pass.SendKeys(_pass);
            btn.Click();
        }
        public void CheckThatRoute(string _exp_route)
        {
            Assert.That(driver.Url, Does.Contain(_exp_route));
        }
    }
}
