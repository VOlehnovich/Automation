using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Guru99
{
    class EmptyFieldAfterRefreshPage
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\chromedriver_win32");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://mail.tut.by/";

            IWebElement login_box = driver.FindElement(By.Id("Username"));
            login_box.SendKeys("VikaOleh@tut.by");
            IWebElement password_box = driver.FindElement(By.Id("Password"));
            password_box.SendKeys("dthf2525");
            driver.Navigate().Refresh();
            if (driver.FindElement(By.Id("Username")).GetAttribute("value") != "" && driver.FindElement(By.Id("Password")).GetAttribute("value") != "")
            {
                closeBrowser();
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
