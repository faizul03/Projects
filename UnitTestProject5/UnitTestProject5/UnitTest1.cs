using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ss-test2.jacksonhewitt.com/Tax-Preparation-Services-Locations/AR/Little-Rock/13412/?pageSection=MakeAppt");

            driver.SwitchTo().Frame(0);
          //  driver.SwitchTo().ParentFrame();
            Thread.Sleep(5000);
        
            driver.FindElement(By.XPath(".//*[@id='footer']/div/div/div[3]/button")).Click();
        }
    }
}
