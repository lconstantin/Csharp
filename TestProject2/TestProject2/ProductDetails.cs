using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject2
{
    class ProductDetails : BasePage
    {
        #region constructor
        public ProductDetails(IWebDriver driver) : base(driver)
        {

            PageFactory.InitElements(driver, this);
        }

       

        #endregion

        [FindsBy(How = How.XPath, Using = "//div[@class='pageHeading']/h2")]
        private IWebElement productTitle;

        [FindsBy(How = How.XPath, Using = "//input[@class='buton_comanda']")]
        private IWebElement cartButton;

        public string CheckTitle()
        {
            string getTitle = productTitle.Text;
            return getTitle;
        }

        public void addToCart() {
            cartButton.Click();
        
        }


        [FindsBy(How = How.XPath, Using = "//a[@class='btn btn-orange pull-right']")]
        private IWebElement goToCartPage;

       

        public CartPage GoToCart()
        {
                
                Thread.Sleep(2000);
                goToCartPage.Click();
                  
            CartPage cartPage = new CartPage(_driver);
            return cartPage;


        }

    }
}

