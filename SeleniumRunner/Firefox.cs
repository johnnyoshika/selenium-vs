using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using static System.Threading.Thread;

namespace SeleniumRunner
{
    public class Firefox
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test_Google_Search()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://www.google.com";

            var input = driver.FindElement(By.CssSelector("[name='q']"));

            input.SendKeys("Vancouver Jobs");

            var button = driver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div[1]/div[3]/center/input[1]"));

            button.Click();

            Sleep(6000);

            Console.WriteLine("Test Passed");
        }
        
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}