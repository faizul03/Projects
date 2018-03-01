using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Appointment_Scheduling_Office_Locator.JhHomepage.Benefits_Of_An_American_Express
{
    [TestFixture]
    public class BenefitsOfAnAmericanExpress
    {
        private IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5000));
            driver.Navigate().GoToUrl("https://ss-test2.jacksonhewitt.com/");


        }




        [Test]
        public void BenefitsOfAnAmericanExpres()
        {
            EAPageBenefitsOfAnAmericanExpress page = new EAPageBenefitsOfAnAmericanExpress(this.driver);

            page.BenefitsOfAnAmericanExpress.Click();
            page.UseCurrentLocation.Click();
            Thread.Sleep(5000);
            page.MakeAnAppointment.Click();
            page.AppointmentDayTime.Click();
            page.selectAtimeslot.Click();
            page.PurposeofAppuintment.SendKeys("Start My Tax Return");
            page.FirstName.SendKeys("Faizul");
            page.LastName.SendKeys("Islam");
            page.TelePhone.SendKeys("9173047858");
            page.Email.SendKeys("Faizul.Islam@jtax.com");
            page.LastFourSSN.SendKeys("0147");
            page.Source.SendKeys("Jacksonhewitt.com");
            page.TextMessage.Click();
            page.AdditionalComments.SendKeys("2014 Tax fill");
            page.ConfirmAppointment.Click();


            // TODO: Add your test code here
            Assert.Pass("Test Pass");
        }
                [TearDown]
        public void Cleanup()
        {
            driver.Quit();

        

            
          


        }
    }
}


