using NUnit.Framework;
using OpenQA.Selenium;

namespace ex402.Pages
{
    internal class RegisterPage : MainPage
    {
        public void RegisterUser(string _url, string _fname, string _lname, string _email, string _phone, string _pass)
        {
            driver.Url = _url;
            IWebElement my_acc = driver.FindElement(By.ClassName("dropdown"));
            my_acc.Click();
            IWebElement register = driver.FindElement(By.LinkText("Register"));
            register.Click();
            IWebElement f_name = driver.FindElement(By.Name("firstname"));
            IWebElement l_name = driver.FindElement(By.Name("lastname"));
            IWebElement email = driver.FindElement(By.Name("email"));
            IWebElement phone = driver.FindElement(By.Name("telephone"));
            IWebElement pass1 = driver.FindElement(By.Name("password"));
            IWebElement pass2 = driver.FindElement(By.Name("confirm"));
            IWebElement agree = driver.FindElement(By.Name("agree"));
            IWebElement btn = driver.FindElement(By.ClassName("btn-primary"));

            f_name.Clear();
            f_name.SendKeys(_fname);
            l_name.Clear();
            l_name.SendKeys(_lname);
            email.Clear();
            email.SendKeys(_email);
            phone.Clear();
            phone.SendKeys(_phone);
            pass1.Clear();
            pass1.SendKeys(_pass);
            pass2.Clear();
            pass2.SendKeys(_pass);
            if (!agree.Selected) agree.Click();
            btn.Click();
        }

        public void CheckThatRoute(string _exp_route)
        {
            Assert.That(driver.Url, Does.Contain(_exp_route));
        }
    }
}
