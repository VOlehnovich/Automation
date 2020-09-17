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
    class UnCheckBoxRememberMe
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

            IWebElement login_box = driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/label/input"));
            login_box.SendKeys("VikaOleh@tut.by");
            IWebElement password_box = driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/label[2]/input"));
            password_box.SendKeys("dthf2525");
            IWebElement signIn_button = driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/div/input"));
            signIn_button.Click();
            driver.Manage().Window.Maximize();

            IWebElement userAccoutName = driver.FindElement(By.XPath("//span[@class='user-account__name']"));
            userAccoutName.Click();

            IWebElement exit = driver.FindElement(By.XPath("//a[@aria-label='Выйти из аккаунта']/span"));
            exit.Click();

            if (driver.FindElement(By.XPath("//input[@name='passwd']")).GetAttribute("value") != "")
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
