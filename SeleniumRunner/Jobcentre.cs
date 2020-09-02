using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Threading.Thread;

namespace SeleniumRunner
{
    public class Jobcentre
    {
        [Test]
        public void Purchase_Single_Job_Plan()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                int purchases = 3;
                string email = "selenium.user@email.com";
                string password = "selenium.user@email.com";

                driver.Url = "https://localhost:44382/contact";

                Sleep(500);

                //Click sign in link
                driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[2]/a[2]")).Click();

                Sleep(500);

                //Enter Email
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div[1]/input")).SendKeys(email);

                //Enter Password
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/div[2]/input")).SendKeys(password);

                //Click Login
                driver.FindElement(By.XPath("/html/body/div[1]/div/div/form/button")).Click();

                Sleep(500);

                //Click Buy More
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[2]/div[1]/div/div[1]/a")).Click();

                Sleep(500);

                for (int i = 0; i < purchases; i++)
                {
                    //Click Button to Buy 1 Job Posting
                    driver.FindElement(By.CssSelector(".pricing-container")).Click();

                    Sleep(800);

                    //Click Continue
                    driver.FindElement(By.CssSelector("body > div.modal.fade.in > div > div > div.modal-body > div > div > form > div.pull-right.u_mt-md > button")).Click();

                    Sleep(1000);

                    //Click No Thanks
                    driver.FindElement(By.CssSelector("body > div.modal.fade.in > div > div > div.modal-body > div > div > div.u_mb-base.clearfix > div.clearfix.text-center > a.btn.btn-custom.btn-primary")).Click();

                    Sleep(800);

                    //Click Submit Payment
                    driver.FindElement(By.CssSelector("body > div.modal.fade.in > div > div > div.modal-body > div > div > form > div.pull-right > button")).Click();

                    Sleep(7000);

                    //Click Continue
                    driver.FindElement(By.CssSelector("body > div.modal.fade.in > div > div > div.modal-body > div > div > div.u_mb-xl.u_p-base.text-center.clearfix > a")).Click();

                    Sleep(1000);
                }
            }
        }
    }
}
