using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestFramework.Utils;

namespace TestFramework.Pages
{
    internal class ItemPage
    {
        private string route_string;
        IWebElement select_item;
        IWebElement btn;
        IWebElement top_cart;
        IWebElement view_cart;
        public string ChoiceColorItemAddToCart()
        {
            route_string = $"index.php?route=product/product&product_id={Values.ITEM_ID}";
            string local_url = Values.URL + route_string;
            Values.driver.Navigate().GoToUrl(local_url);
            if (Values.screenshot) Values.ScreenShot();
            select_item = Values.driver.FindElement(By.TagName("select"));
            btn = Values.driver.FindElement(By.Id("button-cart"));
            var selectObject = new SelectElement(select_item);
            selectObject.SelectByIndex(2);
            if (Values.screenshot) Values.ScreenShot();
            btn.Click();
            if (Values.screenshot) Values.ScreenShot();
            IWebElement alert = Values.driver.FindElement(By.ClassName("alert-success"));

            return alert.Text;
        }

        public string MoveToCart()
        {
            route_string = $"index.php?route=product/product&product_id={Values.ITEM_ID}";
            string local_url = Values.URL + route_string;
            Values.driver.Navigate().GoToUrl(local_url);
            if (Values.screenshot) Values.ScreenShot();
            top_cart = Values.driver.FindElement(By.Id("cart-total"));
            top_cart.Click();
            if (Values.screenshot) Values.ScreenShot();
            view_cart = Values.driver.FindElement(By.LinkText("View Cart"));
            view_cart.Click();
            if (Values.screenshot) Values.ScreenShot();

            return Values.driver.Url;
        }
    }
}
