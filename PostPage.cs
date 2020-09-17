using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guru99
{
    class PostPage
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
            Assert.NotNull(driver.FindElement(By.XPath("//*[@id='container']/div/div/img")).Displayed);
            Assert.NotNull(driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div/div/a/span")).Displayed);

            IWebElement login_box = driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/label/input"));
            login_box.SendKeys("VikaOleh@tut.by");
            IWebElement password_box = driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/label[2]/input"));
            password_box.SendKeys("dthf2525");
            IWebElement signIn_button = driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/div/input"));
            signIn_button.Click();
            String title = driver.Title;
            string b = "Входящие — Яндекс.Почта";
            if (b == title)
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
