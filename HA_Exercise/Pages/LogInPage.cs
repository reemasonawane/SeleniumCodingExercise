using OpenQA.Selenium;

namespace SeleniumAssignment.Pages
{
    class LogInPage
    {
        IWebDriver webDriver;

        #region WebElements
        By usernameTextBoxElement = By.Id("log");
        By pwdTextBoxElement = By.Id("pwd");
        By logInButtonlement = By.Id("login");
        #endregion

        public LogInPage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void logIn()
        {
            webDriver.FindElement(usernameTextBoxElement).SendKeys("testSeleniumCsharp");
            webDriver.FindElement(pwdTextBoxElement).SendKeys("test$$26");
            webDriver.FindElement(logInButtonlement).Click();
        }
    }
}
