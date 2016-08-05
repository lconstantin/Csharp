using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject2
{
    class CategoryPage : BasePage
    {
        public CategoryPage(IWebDriver driver) : base(driver)
        {
            
        }
        [FindsBy(How = How.ClassName, Using = "breadCrumb")]
        private IWebElement lableCategoryPath;

        public List<string> GetLableCategory() {
            var list = new List<string>();
            foreach (var item in lableCategoryPath.FindElements(By.TagName("b"))) {
                list.Add(item.Text.Trim());
            }
            return  list;
        }
    }
}
