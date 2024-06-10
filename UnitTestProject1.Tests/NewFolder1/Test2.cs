using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Tests
{
    [TestClass]
    public class Test2
    {
        private static IWebDriver driver;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ebay.com");
        }

        [ClassCleanup]
        public static void TearDown()
        {
            driver.Quit();
        }

        [TestMethod]
        public void Test2_search()
        {
            var searchButton = driver.FindElement(By.Id("gh-btn"));
            Assert.IsNotNull(searchButton, "Elements ar ID 'gh-btn' nav atrasts.");
        }
    }
}
