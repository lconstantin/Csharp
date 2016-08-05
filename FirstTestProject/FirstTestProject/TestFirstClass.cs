using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FirstTestProject
{
    [TestFixture]
    public class TestFirstClass
    {
        private IWebDriver _driver;    

        [SetUp]
        public void Ceva() {

            _driver = new FirefoxDriver();
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
        }

        [TearDown]
        public void Altceva() {

        }

        [Test]
        public void FirstTest() {

            _driver.Navigate().GoToUrl("https://www.google.ro/");
            var searchBox = _driver.FindElement(By.Name("q"));
            searchBox.Clear();
            searchBox.SendKeys("Selenium");
            searchBox.Submit();

            var result = _driver.FindElement(By.ClassName("r")).FindElement(By.TagName("a"));

            Assert.IsTrue(result.Text.Contains("Selenium"));

        }
    }
}
