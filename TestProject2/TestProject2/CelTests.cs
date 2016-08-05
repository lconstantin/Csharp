using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject2
{   
    [TestFixture]
    class CelTests
    {
        private IWebDriver driver;
        private HomePage homePage;
        private CategoryPage categoryPage;
        
        [SetUp]
        public void SetUp() {

            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            DriverManagementUtils.SetWait(ref driver, 30);

            homePage = new HomePage(driver);
            categoryPage = new CategoryPage(driver);
        }

        [TearDown]
        public void TearDown() {

        }

        [Test]
        public void FirstCelTestMethod() {

            DriverManagementUtils.NavigateToURL(driver, "http://www.cel.ro");
            Assert.IsTrue(homePage.GetPageTitle().Contains("CEL"));

            Assert.IsTrue(homePage.IsLogoDisplayed());

            homePage.ClickNotification();
            var valoaremeniu = homePage.SelectFromMenu(7, 2);

            Assert.IsTrue(homePage.GetPageTitle().Contains(valoaremeniu));
            string[] listaLabel = { "CEL.ro", "Software", "Antivirus" };
            var list = categoryPage.GetLableCategory();

            foreach (var item in list) {

                Assert.AreEqual(item, listaLabel[list.IndexOf(item)]);
            }
        }
    }
}
