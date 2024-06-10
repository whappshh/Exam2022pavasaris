using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Tests
{
    [TestClass]
    public class Test1
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
        public void Test1_field()
        {
            var searchBox = driver.FindElement(By.Id("gh-ac"));
            Assert.IsNotNull(searchBox, "Elements ar ID 'gh-ac' nav atrasts.");
        }
    }
}
