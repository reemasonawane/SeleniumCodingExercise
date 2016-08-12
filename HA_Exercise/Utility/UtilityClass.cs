using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAssignment.Utility
{
    class UtilityClass
    {

        IWebDriver webDriver;

        public IWebDriver setBrowserDriver(string browser)
        {
            switch (browser)
            {
                case WebDrivers.chrome:
                    webDriver = new ChromeDriver();
                    break;
                case WebDrivers.ie:
                    webDriver = new InternetExplorerDriver();
                    break;
                case WebDrivers.mozilla:
                    //webDriver = new Web
                    break;
                default:
                    break;
            }
            return webDriver;
        }

        public void StopDriver(IWebDriver driver)
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

    }
}
