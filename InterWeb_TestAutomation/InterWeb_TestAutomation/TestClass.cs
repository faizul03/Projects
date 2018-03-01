using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterWeb_TestAutomation
{


    [TestFixture]
    public class TestClass
    {
        IWebDriver driver = new FirefoxDriver();
        

        [Test]
        public void TestMethod()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("www.jacksonhewitt.com");
            

            // TODO: Add your test code here

            IWebElement  Enter = driver.FindElement(By.XPath(""));

            IWebElement bb = driver.FindElement(By.XPath(""));

            i
            
             
            Assert.Pass("Your first passing test");

        }





     
        




         [TearDown]
        public void Cleanup()
        {

            driver.Quit();
        }

    }
}

      


   
