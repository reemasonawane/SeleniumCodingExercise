using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumAssignment.Pages;
using SeleniumAssignment.Utility;
using System.Configuration;

namespace SeleniumAssignment.Tests
{
    [TestClass]
    public class OrderApplePhoneTest
    {
        IWebDriver webDriver;

        [TestMethod]
        public void submitOrderForIPhone()
        {
            UtilityClass util = new UtilityClass();
            webDriver = util.setBrowserDriver("CHROME");
            webDriver.Url = ConfigurationManager.AppSettings["URL"];

            ProductCatlogIphonePage pcp = new ProductCatlogIphonePage();
            pcp.goToProductIphonePage(webDriver);

            CheckOutPage ch = new CheckOutPage(webDriver);
            ch.VerifyAmountandContinue();
            util.StopDriver(webDriver);
        }

    }
}
