using NUnit.Framework;
using OpenQA.Selenium;
using ex402.Utils;

namespace ex402.Pages
{
    internal class RegisterPage
    {
        public string RegisterUser(string _url, string _fname, string _lname, string _email, string _phone, string _pass)
        {
            Values v = new Values();
            v.driver.Url = _url;
            IWebElement my_acc = v.driver.FindElement(By.ClassName("dropdown"));
            my_acc.Click();
            IWebElement register = v.driver.FindElement(By.LinkText("Register"));
            register.Click();
            IWebElement f_name = v.driver.FindElement(By.Name("firstname"));
            IWebElement l_name = v.driver.FindElement(By.Name("lastname"));
            IWebElement email = v.driver.FindElement(By.Name("email"));
            IWebElement phone = v.driver.FindElement(By.Name("telephone"));
            IWebElement pass1 = v.driver.FindElement(By.Name("password"));
            IWebElement pass2 = v.driver.FindElement(By.Name("confirm"));
            IWebElement agree = v.driver.FindElement(By.Name("agree"));
            IWebElement btn = v.driver.FindElement(By.ClassName("btn-primary"));

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

            return v.driver.Url;
        }
    }
}
