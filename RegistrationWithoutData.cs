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
    class RegistrationWithoutData
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

            IWebElement registrationButton = driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div/div/a/span"));
            registrationButton.Click();

            IWebElement regButton = driver.FindElement(By.XPath("//button[@id='reg_submit']"));
            Boolean status = regButton.Enabled;
            if (status == true)
            {
                closeBrowser();
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
