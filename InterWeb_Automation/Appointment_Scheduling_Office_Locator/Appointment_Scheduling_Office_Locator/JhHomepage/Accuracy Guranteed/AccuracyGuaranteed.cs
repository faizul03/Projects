using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduling_Office_Locator.JhHomepage.Accuracy_Guranteed
{
    [TestFixture]
    public class AccuracyGuaranteed

    {
        private IWebDriver driver;

        [SetUp]
        public void Initialize()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

        }

        [Test]
        public void AccuracyGuaranteedr()
        {
            // TODO: Add your test code here

            //driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            // driver.Navigate().GoToUrl("https://ss-test2.jacksonhewitt.com/");
            //Console.WriteLine(driver.Url);
            //Console.WriteLine(driver.Title);

            EA_Accuracy_POM Page = new EA_Accuracy_POM(this.driver);

            Page.AccuracyGuaranteed.Click();
            Page.EnterCity_State_Zip.SendKeys("72211");
            Page.Find_A_Office_NearYOu.Click();
            Page.Make_An_Appointment.Click();
            Page.Appointment_Day_Time.Click();
            //driver.Navigate().Back();

            // Thread.Sleep(3000);
            Page.select_A_timeslot.Click();
            Page.Purpose_of_Appuintment.SendKeys("Start My Tax Return");
            Page.FirstName.SendKeys("Faizul");
            Page.LastName.SendKeys("Islam");
            Page.TelePhone.SendKeys("5555555555");
            Page.Email.SendKeys("faizul.islam@jtax.com");
            Page.Last_Four_SSN.SendKeys("0147");
            Page.Source.SendKeys("JacksonHewitt.com");
            Page.Text_Message.Click();
            Page.Additional_Comments.SendKeys("2016 Tax fill");
            Page.Confirm_Appointment.Click();


            // Assert.Pass("Your first passing test");

        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }


    }
}
