using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JacksonWewitt_.ModalNewsletter
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
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
            System.Diagnostics.Debug.WriteLine(driver.Url);
            System.Diagnostics.Debug.WriteLine(driver.Title);
        }

        [Test]
        public void Modal()
        {
           ModalObjectPage page = new ModalObjectPage(this.driver);

            Thread.Sleep(15000); // will wait 15 seconds for modal to pop up. 
            page.EnterFirstName.SendKeys("Sean Jackson");
            page.EnterEmailAddress.SendKeys("faizulislam@jtax.com");





            if (page.SignMeUp.Text == "Sign Me Up!\r\nI agree to receiving emails from Jackson Hewitt")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                // if test fail 

                Console.WriteLine("Test Failed");
            }
            var testme = page.SignMeUp.Text;

            // check to if the SignUp button  exists
            Assert.AreEqual(page.SignMeUp.Text, "Sign Me Up!\r\nI agree to receiving emails from Jackson Hewitt");
            Console.WriteLine("Test Passed");
            Console.WriteLine("Assert: Sign Me Up!\r\nI agree to receiving emails from Jackson Hewitt");

            page.SignMeUp.Click();
            Thread.Sleep(5000);




        }



        [TearDown]
        public void cleanUp()
        {
            driver.Quit();
        }




    }
}

