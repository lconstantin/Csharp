using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestProject2
{
    
    
    public class DriverManagementUtils
    {
        public static void NavigateToURL(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void SetWait(ref IWebDriver driver, int waitTime)
        {
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(waitTime));
        }
    }
}
