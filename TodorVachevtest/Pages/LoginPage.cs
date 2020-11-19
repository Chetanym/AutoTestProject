using AutoTestFramework.Base;
using OpenQA.Selenium;


namespace TodorVachevtest.Pages
{
    class LoginPage
    {
        //private RemoteWebDriver _driver;
        //public LoginPage(RemoteWebDriver driver) 
        //{
        //    _driver = driver;
        //}
        //public LoginPage(RemoteWebDriver driver): base(driver) 
        //{

        //}


        //public IWebElement lnkTestScenario => _driver.FindElementById("menu-item-58");

        //public IWebElement lnkTestScenario => DriverContext.Driver.FindElementById("menu-item-58");
        //public IWebElement lnkLogin => DriverContext.Driver.FindElementByLinkText("Login Form");

        IWebElement txtUserName => DriverContext.Driver.FindElement(By.Name("userid"));
        IWebElement txtPassword => DriverContext.Driver.FindElement(By.Name("passid"));
        IWebElement txtRepeatPassword => DriverContext.Driver.FindElement(By.Name("repeatpassid"));
        IWebElement btnLogin => DriverContext.Driver.FindElement(By.Name("submit"));

        // _driver.FindElement(By.Id("menu-item-58")).Click();

        // _driver.FindElement(By.LinkText("Login Form")).Click();

        // _driver.FindElement(By.Name("userid")).SendKeys("admin");
        // _driver.FindElement(By.Name("passid")).SendKeys("asdf123");
        // _driver.FindElement(By.Name("repeatpassid")).SendKeys("asdf123");
        // _driver.FindElement(By.Name("submit")).Click();


        public void Loggingin(string username, string password, string repeatpassword)
        {

            //page.lnkTestScenario.Click();
            //page.lnkLogin.Click();
            //page.txtUserName.SendKeys("admin");
            //page.txtPassword.SendKeys("asdf123");
            //page.txtRepeatPassword.SendKeys("asdf123");
            //page.btnLogin.Click();

            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            txtRepeatPassword.SendKeys(repeatpassword);
            btnLogin.Click();

        }

        //public void clickloginlink()
        //{

          //  lnkTestScenario.Click();
            //lnkLogin.Click();

        //}

    }
}
