using AutoTestFramework.Base;
using AutoTestFramework.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using TodorVachevtest.Pages;
using static AutoTestFramework.Base.Browser;

namespace TodorVachevtest
{
    [TestClass]
    public class UnitTest1
    {

        string url = "https://testing.todorvachev.com/";
        
        public void OpenBrowser(BrowserType browsertype)
        {
            switch (browsertype)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext._browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext._browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext._browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext._browser = new Browser(DriverContext.Driver);
                    break;
            }


        }

        [TestMethod]
        public void TestMethod1()
        {


            //DriverContext.Drirver = new FirefoxDriver();
            //DriverContext.Driver.Navigate().GoToUrl(url);
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";

            ExcelHelpers.PopulateInCollection(fileName);


            LogHelpers.CreateLogFile();
            OpenBrowser(BrowserType.FireFox);
            LogHelpers.Write("Opened the browser !!!");

            DriverContext._browser.GotoUrl(url);


            TestScenarioPage page = new TestScenarioPage();

            LoginFormPage loginForm = page.ClickTestScenario();
            LoginPage login = loginForm.clickLoginForm();
            login.Loggingin(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"), 
                ExcelHelpers.ReadData(1, "RepeatPassword"));
        }


    }
}
