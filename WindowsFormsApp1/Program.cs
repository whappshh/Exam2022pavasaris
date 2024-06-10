using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1
{
    static class Program
    {
        static IWebDriver driver;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ebay.com");
            Application.Run(new Form1());
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
