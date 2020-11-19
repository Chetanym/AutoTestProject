using AutoTestFramework.Base;
using OpenQA.Selenium;

namespace TodorVachevtest.Pages
{
    class LoginFormPage
    {

        IWebElement lnkLogin => DriverContext.Driver.FindElement(By.LinkText("Login Form"));

        public LoginPage clickLoginForm()
        {
            lnkLogin.Click();
            return new LoginPage();
        }

    }
}
