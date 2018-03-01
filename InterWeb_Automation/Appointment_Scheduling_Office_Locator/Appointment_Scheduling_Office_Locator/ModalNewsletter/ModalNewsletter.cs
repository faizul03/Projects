using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Appointment_Scheduling_Office_Locator.ModalNewsletter
{
    [TestFixture]
    public class ModalNewsletter
    {
        private IWebDriver driver;
        [SetUp]
        public void Initialize()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://ss-dev2.jacksonhewitt.com/");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
        }

        [Test]
        public void Modal()
        {
            EAModal page = new EAModal(this.driver);

            page.EnterFirstName.SendKeys("Sean Jackson");
            page.EnterEmailAddress.SendKeys("Faizul.islam@jtax.com");
            //var testme = page.SignMeUp.Text;


            if (page.SignMeUp.Text == "Sign Me Up!\r\nI agree to receiving emails from Jackson Hewitt")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

           // Assert.Pass("Your first passing test");
            page.SignMeUp.Click();
            Console.WriteLine("Assert: Sign Me Up!\r\nI agree to receiving emails from Jackson Hewitt");
            Thread.Sleep(3000);
            

            
           
            
        } 


           
         [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

    }
}