using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment.Pages
{
    public class CheckOutPage
    {
        IWebDriver driver;
        #region Webelements
        By subTotal = By.CssSelector(".pricedisplay");
        By cntElement = By.ClassName("step2");
        By purchaseElement = By.CssSelector("input[value='Purchase']");
        By removeElement = By.CssSelector("input[value='Remove']");
        By emptyMessage = By.CssSelector("div[class='entry-content']");
        #endregion

        public CheckOutPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        public void VerifyAmountandContinue()
        {
            Assert.AreEqual("$270.00", driver.FindElement(subTotal).Text);
            driver.FindElement(cntElement).Click();
            Console.WriteLine("Amount verified");
        }

        public void removeItemFromCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 120));
            wait.Until(p => p.FindElement(purchaseElement).Displayed);
            driver.FindElement(purchaseElement).Click();
            wait.Until(p => p.FindElement(removeElement).Displayed);
            driver.FindElement(removeElement).Click();
            Assert.AreEqual("Oops, there is nothing in your cart.", driver.FindElement(emptyMessage).Text);
            Console.WriteLine("Item remove successfully");
        }
    }
}
