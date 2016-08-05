using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject2
{
    public class BasePage


    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {

            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string GetPageTitle() {
          return _driver.Title;
        }
    }

}
