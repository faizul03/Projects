using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc
{
    [TestFixture]
    public class TestClass
    {
        [SetUp]
        public void Start()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ss-test2.jacksonhewitt.com/Tax-Preparation-Services-Locations/AR/Little-Rock/13412/?pageSection=MakeAppt");

            driver.SwitchTo().Frame(0);
            driver.FindElement(By.XPath(".//*[@id='footer']/div/div/div[3]/button")).Click();


        }
    }
}
