using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject2
{
    class CartPage : BasePage
    {

        public CartPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "breadCrumb")]
        private IWebElement labelCartPath;

        // public List<string> GetLabelCart()

        //   {
        //     var list = new List<string>();
        //     foreach (var item in labelCartPath.FindElements(By.TagName("span")))
        //     {
        //          list.Add(item.Text.Trim());
        //      }
        //      return list;
        //   }

        
        [FindsBy(How = How.XPath, Using = "//input[contains(@onchange,'actualizeaza_produs')]")]
        private IWebElement quantity;

        [FindsBy(How = How.XPath, Using = "//td[@class='productListing-data']/b")]
        private IWebElement singlePrice;

        [FindsBy(How = How.XPath, Using = "//td[@class='productListing-data fprice']/b")]
        private IWebElement totalPrice;

        public void increaseQuantity() {
            quantity.Clear();
            quantity.SendKeys("3");
        }

        public int getSinglePrice() {
            int value;
            int.TryParse(singlePrice.Text, out value);
            return value;
        }
        public int getQuantity() {
            int val;
            string s = quantity.GetAttribute("value");
            int.TryParse(s, out val);
            return val;
        }

        public int getTotalPrice()
        {
            int totalValue;
            int.TryParse(totalPrice.Text, out totalValue);
            return totalValue;
        }

        //verificare daca apare numele de continut cos
        [FindsBy(How = How.ClassName, Using = "breadCrumb")]
        private IWebElement lableCategoryPath;

        public List<string> GetLableCategory()
        {
            var list = new List<string>();
            foreach (var item in lableCategoryPath.FindElements(By.TagName("span")))
            {
                list.Add(item.Text.Trim());
            }
            return list;
        }

    }
}
