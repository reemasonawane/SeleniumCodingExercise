using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumAssignment.Pages;
using SeleniumAssignment.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment.Tests
{
    [TestClass]
    public class VerifyAccountDetailsTest
    {
        IWebDriver webDriver;
        [TestMethod]
        public void verifySavedAccountDetails()
        {
            UtilityClass util = new UtilityClass();
            webDriver = util.setBrowserDriver("CHROME");
            webDriver.Url = ConfigurationManager.AppSettings["URL"];

            HomePage hp = new HomePage(webDriver);
            hp.accountPage();
            LogInPage log = new LogInPage(webDriver);
            log.logIn();
            YourAccountPage accp = new YourAccountPage(webDriver);
            accp.showDetails();
            accp.updateField();
            AfterLogOutLogInPage loi = new AfterLogOutLogInPage(webDriver);
            loi.LogInAgainToVerifyDetails();
            hp.accountPage();
            log.logIn();
            accp.showDetails();
            accp.verifyDetails();
            util.StopDriver(webDriver);
        }
    }
}
