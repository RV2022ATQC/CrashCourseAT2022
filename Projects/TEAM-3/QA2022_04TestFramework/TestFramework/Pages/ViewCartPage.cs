using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using TestFramework.Utils;

namespace TestFramework.Pages
{
    internal class ViewCartPage
    {
        private string route_string;
        IWebElement btn;
        IWebElement empty_cart;

        public string DeleteIntemFromCart()
        {
            route_string = "index.php?route=checkout/cart";
            string local_url = Values.URL + route_string;
            Values.driver.Navigate().GoToUrl(local_url);
            if (Values.screenshot) Values.ScreenShot();
            btn = Values.driver.FindElement(By.XPath(" //*[@id='content']/form/div/table/tbody/tr/td[4]/div/span/button[2]"));
            btn.Click();
            if (Values.screenshot) Values.ScreenShot();
            empty_cart = Values.driver.FindElement(By.XPath("//*[@id='cart-total']"));
            return empty_cart.Text;
        }
    }
}
