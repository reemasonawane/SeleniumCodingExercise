using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;

namespace SeleniumAssignment.Pages
{
    public class YourAccountPage
    {
        IWebDriver webDriver;

        #region WebElements
        By detailsLinkElement = By.LinkText("Your Details");
        By postalCode = By.Id("wpsc_checkout_form_8");
        By saveButton = By.CssSelector("input[value='Save Profile']");
        By logOut = By.LinkText("Log out");

        #endregion

        string randomNo = new Random().Next().ToString();

        public YourAccountPage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void showDetails()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.FindElement(detailsLinkElement).Displayed);
            webDriver.FindElement(detailsLinkElement).Click();
        }

        public void updateField()
        {
            webDriver.FindElement(postalCode).Clear();
            webDriver.FindElement(postalCode).SendKeys(randomNo);
            webDriver.FindElement(saveButton).Click();
            webDriver.FindElement(logOut).Click();
        }

        public void verifyDetails()
        {
            Debug.WriteLine(randomNo);
            Debug.WriteLine(webDriver.FindElement(postalCode).GetAttribute("value"));
            Assert.AreEqual(randomNo, webDriver.FindElement(postalCode).GetAttribute("value"));
            Console.WriteLine("Updated details verified successfully");
        }
    }
}

