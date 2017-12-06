using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace google_bot
{
    public partial class Form1 : Form
    {
        IWebDriver PJS;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PJS = new PhantomJSDriver();
            PJS.Manage().Window.Maximize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PJS.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PJS.Navigate().GoToUrl("https://www.google.by");
            (PJS as PhantomJSDriver).GetScreenshot().SaveAsFile("d:\\google_bot\\test.jpg", OpenQA.Selenium.ScreenshotImageFormat.Jpeg);
        }
    }
}
