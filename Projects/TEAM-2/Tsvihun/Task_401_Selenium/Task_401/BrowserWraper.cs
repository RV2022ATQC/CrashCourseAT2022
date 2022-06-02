using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;

namespace Task_401_Selenium
{
    public static class BrowserWraper
    {

        //public static IWebDriver GetBrowser()
        //{
        //    //var runName = GetType().Assembly.GetName().Name;
        //    var timestamp = $"{DateTime.Now:yyyyMMdd.HHmm}";

        //    var timespan = TimeSpan.FromMinutes(3);
        //    ChromeDriverService service = ChromeDriverService.CreateDefaultService();

        //    ChromeOptions options = new FirefoxOptions();
        //    options.AddArguments("--start-maximized");
        //    options.AddArguments("--no-proxy-server");
        //    options.AddArguments("--ignore-certificate-errors");
        ///*    options.AddAdditionalCapability("name", runName, true);
        //    options.AddAdditionalCapability("videoName", $"{runName}.{timestamp}.mp4", true);
        //    options.AddAdditionalCapability("logName", $"{runName}.{timestamp}.log", true);
        //*/    options.AddAdditionalCapability("enableVNC", true, true);
        //    options.AddAdditionalCapability("enableVideo", true, true);
        //    options.AddAdditionalCapability("enableLog", true, true);
        //    options.AddAdditionalCapability("screenResolution", "1920x1080x24", true);
        
        //    var _driver = new RemoteWebDriver(new Uri("http://127.0.0.1:4445/wd/hub"), options);

        //    return _driver;
        //}


    }
}
