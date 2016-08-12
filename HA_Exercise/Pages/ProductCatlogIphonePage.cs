using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeleniumAssignment
{
    public class ProductCatlogIphonePage
    {
        #region WebElements
        By iphoneAddCart = By.CssSelector("div.iphones form");
        By goTocheckout = By.CssSelector(".go_to_checkout");
        #endregion

        public void goToProductIphonePage(IWebDriver driver)
        {
            driver.Url = "http://store.demoqa.com/products-page/product-category/iphones/ ";
            clickAddToCart(driver);
        }

        public void clickAddToCart(IWebDriver driver)
        {
            ReadOnlyCollection<IWebElement> reservationDetails = driver.FindElements(iphoneAddCart);
            bool isAddedToCart = false;
            for (int i = 0; i < reservationDetails.Count; i++)
            {
                if (reservationDetails[i].GetAttribute("action").Contains("apple-iphone-4s-16gb-sim-free-black"))
                {
                    reservationDetails[i].FindElement(By.CssSelector("div.input-button-buy input")).Click();
                    isAddedToCart = true;
                    break;
                }
            }
            if (isAddedToCart)
            {
                gotoCheckOut(driver);
            } 
        }

        public void gotoCheckOut(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.FindElement(goTocheckout).Displayed);
            driver.FindElement(goTocheckout).Click();
        }

    }
}
