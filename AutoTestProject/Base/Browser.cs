

using OpenQA.Selenium;

namespace AutoTestFramework.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;
        public Browser(IWebDriver Driver)
        {
            _driver = Driver;
        }

       // //public BrowserType Type { get; set; }

        public void GotoUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }

        public enum BrowserType
        {
            InternetExplorer,
            FireFox,
            Chrome
        }
    }
}
