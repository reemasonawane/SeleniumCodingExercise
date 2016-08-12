using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using SeleniumAssignment.Utility;
using System;
using System.Diagnostics;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumAssignment
{

    public class HomePage
    {
        IWebDriver webDriver;

        #region Webelements
        By dropDownIphoneElement = By.Id("menu-item-37");
        By linkProductCategory = By.LinkText("Product Category");
        By myAccount = By.CssSelector("a[title='My Account']");
        #endregion

        public HomePage(IWebDriver driver)
        {
            this.webDriver = driver;
        }

        public void orderAppleIphone()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, System.TimeSpan.FromSeconds(120));
            wait.Until(d => d.FindElement(linkProductCategory).Displayed);

            Actions act = new Actions(webDriver);
            act.MoveToElement(webDriver.FindElement(linkProductCategory)).Perform();
            webDriver.FindElement(dropDownIphoneElement).Click();
        }

        public void accountPage()
        {
            WebDriverWait wait = new WebDriverWait(webDriver, System.TimeSpan.FromSeconds(120));
            wait.Until(d => d.FindElement(myAccount).Displayed);
            webDriver.FindElement(myAccount).Click();
        }
    }
}
