
using OpenQA.Selenium;

namespace AutoTestFramework.Base
{
    public static class DriverContext
    {
        //private static IWebDriver _driver;

        //public static IWebDriver Driver
        //{
        //    get
        //    {
        //        return _driver;
        //    }
        //    set
        //    {
        //        _driver = value;
        //    }
        //}

        public static IWebDriver Driver { get; set; }

        public static Browser _browser  { get; set; }
    }
}
