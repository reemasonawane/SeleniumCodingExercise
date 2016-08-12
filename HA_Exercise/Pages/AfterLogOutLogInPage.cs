using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment.Pages
{
    public class AfterLogOutLogInPage
    {
        IWebDriver webDriver;
       
        By backToHomePage = By.CssSelector("a[title='Are you lost?']");

        public AfterLogOutLogInPage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void LogInAgainToVerifyDetails()
        {
            webDriver.FindElement(backToHomePage).Click();
        }
    }
}
