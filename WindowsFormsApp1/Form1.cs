using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            var driver = Program.GetDriver();
            var searchBox = driver.FindElement(By.Id("gh-ac"));
            searchBox.Clear();
            searchBox.SendKeys(textBox1.Text); 

            var searchButton = driver.FindElement(By.Id("gh-btn"));
            searchButton.Click();

            var currentUrl = driver.Url;
            textBox2.Text = currentUrl; 
            richTextBox1.AppendText(currentUrl + "\n"); 
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            var driver = Program.GetDriver();
            driver.Navigate().Back();
            textBox1.Clear(); 
            textBox2.Clear(); 
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            var driver = Program.GetDriver();
            driver.Quit();
        }
    }
}
