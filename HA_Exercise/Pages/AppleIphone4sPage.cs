using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumAssignment.Pages
{
    public class AppleIphone4sPage
    {
        By btnaddCart = By.ClassName("wpsc_buy_button");
        By goTocheckout = By.CssSelector(".go_to_checkout");
        
        public void addTocartIphone(IWebDriver driver)
        {
            driver.FindElement(btnaddCart).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.FindElement(goTocheckout).Displayed);
            driver.FindElement(goTocheckout).Click();

        }

    }
}
