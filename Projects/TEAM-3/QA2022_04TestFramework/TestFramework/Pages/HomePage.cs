using System.Threading;

using NUnit.Framework;
using OpenQA.Selenium;
using TestFramework.Utils;


namespace TestFramework.Pages
{
    internal class HomePage
    {
        private string route_string;
        IWebElement item;
        IWebElement my_acc;
        IWebElement logout;
        IWebElement logout_msg;

        public string ChoiceCanon5D()
        {
            route_string = "index.php?route=common/home";
            string local_url = Values.URL + route_string;
            Values.driver.Navigate().GoToUrl(local_url);
            item = Values.driver.FindElement(By.LinkText("Canon EOS 5D"));
            item.Click();
            if (Values.screenshot) Values.ScreenShot();

            return Values.driver.Url;
        }

        public string Logout()
        {
            route_string = "index.php?route=common/home";
            string local_url = Values.URL + route_string;
            Values.driver.Navigate().GoToUrl(local_url);
            if (Values.screenshot) Values.ScreenShot();
            my_acc = Values.driver.FindElement(By.XPath("//*[@id='top-links']/ul/li[2]/a"));
            my_acc.Click();
            if (Values.screenshot) Values.ScreenShot();
            logout = Values.driver.FindElement(By.LinkText("Logout"));
            logout.Click();
            if (Values.screenshot) Values.ScreenShot();

            logout_msg = Values.driver.FindElement(By.XPath("//*[@id='content']/h1"));
            
            return logout_msg.Text;
        }
    }
}
