using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openChome_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com.vn");
            //driver.Close();
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Demo with selenium");
           // element.SendKeys(txtURL.Text);
        }

        private void btn_opnchome2_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = txtURL.Text;
            driver.Navigate();

        }
    }
}
