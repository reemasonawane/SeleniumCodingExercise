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
   public class EmptyCartMessageTest
    {
        IWebDriver webDriver;

        [TestMethod]
        public void verifyEmptyCartMessage()
        {
            UtilityClass util = new UtilityClass();
            webDriver = util.setBrowserDriver("CHROME");
            webDriver.Url = ConfigurationManager.AppSettings["URL"];
                       
            ProductCatlogIphonePage pcp = new ProductCatlogIphonePage();
            pcp.goToProductIphonePage(webDriver);
           
            CheckOutPage ch = new CheckOutPage(webDriver);
            ch.VerifyAmountandContinue();
            ch.removeItemFromCart();
            util.StopDriver(webDriver);
        }

    }
}
