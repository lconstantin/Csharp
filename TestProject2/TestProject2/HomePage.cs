using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject2
{
    class HomePage : BasePage
    {
        #region Constructor
        public HomePage(IWebDriver driver) : base(driver) 
        {
            
        }
        #endregion

        #region Locators
        [FindsBy(How = How.XPath, Using = "//a[@id = 'logo_head']/img")]
        private IWebElement logo;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'cabral']/img")]
        private IWebElement notification;

        [FindsBy(How = How.ClassName, Using = "niv1")]
        private IList<IWebElement> leftMenu ;

        [FindsBy(How = How.XPath, Using = "//h2/a[contains(@href,'kaspersky-internet-security-2016-3-pc-plus1-gratis-1-an')]")]
        private IWebElement pcProduct;

       
        #endregion

        #region Methods
        public bool IsLogoDisplayed()
        {
            return logo.Displayed;
        }

        public void ClickNotification()
        {
            try {
                if (notification.Displayed)
                {
                    notification.Click();
                }
            }
            catch (NoSuchElementException e) {
                Debug.WriteLine(e.Message);

            }
            
        }

        public string SelectFromMenu(int index, int indexSubmeniu) {

            var element = leftMenu[index];
            Actions action = new Actions(_driver);
            action.MoveToElement(leftMenu[index]).Build().Perform();
            return SelectFromSubmeniu(indexSubmeniu, element);
        }

        public string SelectFromSubmeniu(int index, IWebElement element)
        {
            var submeniu = element.FindElements(By.ClassName("aa"))[index];
            var text = submeniu.Text.Trim().Split(' ')[0];
            submeniu.Click();
            return text;
        }

        public ProductDetails GoToDetailsPge() {
            pcProduct.Click();
            
            ProductDetails productDetails = new ProductDetails(_driver);

            return productDetails;
        }

        public string ClickOnPCProduct() {
            string getName = pcProduct.Text;
            return getName;
        }

       
        #endregion

    }
}
