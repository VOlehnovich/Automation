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
    class LoginWithEmptyData
    {
        IWebDriver n_driver;

        [SetUp]
        public void startBrowser()
        {
            n_driver = new ChromeDriver("D:\\chromedriver_win32");
        }

        [Test]
        public void test()
        {
            n_driver.Url = "https://mail.tut.by/";

            IWebElement login_box = n_driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/label/input"));
            login_box.SendKeys("VikaOleh@tut.by");
            IWebElement password_box = n_driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/label[2]/input"));
            password_box.SendKeys("");
            IWebElement signIn_button = n_driver.FindElement(By.XPath("//*[@id='container']/div/div[2]/div/div[2]/div/form/fieldset/div/input"));
            signIn_button.Click();

            string text = n_driver.SwitchTo().Alert().Text;
            Assert.IsTrue(text.Contains("Проверьте, пожалуйста, имя и пароль"));
            n_driver.Quit();
        }
    }
}
