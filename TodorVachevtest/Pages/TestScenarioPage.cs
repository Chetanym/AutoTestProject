using AutoTestFramework.Base;
using OpenQA.Selenium;


namespace TodorVachevtest.Pages
{
    class TestScenarioPage
    {
        IWebElement lnkTestScenario => DriverContext.Driver.FindElement(By.Id("menu-item-58"));

        public LoginFormPage ClickTestScenario()
        {
            lnkTestScenario.Click();
            return new LoginFormPage(); 
        }
    }
}
