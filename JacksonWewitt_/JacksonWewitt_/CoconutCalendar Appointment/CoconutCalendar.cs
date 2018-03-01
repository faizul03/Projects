using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JacksonWewitt_.CoconutCalendar_Appointment
{
    [TestFixture]
    public class CoconutCalendar
    {
        private IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            //driver = new ChromeDriver();
            //driver = new FirefoxDriver(new FirefoxOptions());
            driver = new FirefoxDriver();



            // driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

        }
        [Test]
        public void FindOffice()
        {
            CoconutCalendarObjectsPage page = new CoconutCalendarObjectsPage(this.driver);

            page.EnterCityStateZip.SendKeys("72211");

            var test = page.FindAnOfficeNearYOu.Text;

            Assert.AreEqual(page.FindAnOfficeNearYOu.Text, "FIND AN OFFICE NEAR YOU");
            Console.WriteLine("Test Passed");

            if (page.FindAnOfficeNearYOu.Text == "FIND AN OFFICE NEAR YOU")
            {
                Console.WriteLine("Button found");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            page.FindAnOfficeNearYOu.Click();




            Thread.Sleep(2000);
            page.ALL.SendKeys("All");
            page.Walmart.SendKeys("Walmart");
            Thread.Sleep(2000);
            page.OpenYeaRound.SendKeys("Open Year Round");
            page.OffersRefundAdvance.SendKeys("Offers Refund Advance");
            page.OfficeInfo.Click();
            Thread.Sleep(2000);
            page.TrafficMap.Click();
            Thread.Sleep(3000);
            page.BackResults.Click();
            Thread.Sleep(3000);
            page.MakeAnAppointment.Click();
            driver.SwitchTo().Frame(0);
            Thread.Sleep(3000);
            page.ChooseTime.Click();
            page.ClickNext.Click();
            Thread.Sleep(3000);
            if (page.ClickNext.Text == "Next")
            {
                Console.WriteLine("Please select a time slot: Test Fail");
            }
            else
            {
                Console.WriteLine("Test failed due not selecting time");
            }

        }

       
        [Test]
        public void CloseIframe()
        {
           
            CoconutCalendarObjectsPage page = new CoconutCalendarObjectsPage(this.driver);
            page.FindAnOfficeNearYOu.Click();
            Thread.Sleep(2000);
            page.ALL.SendKeys("All");
            page.Walmart.SendKeys("Walmart");
            Thread.Sleep(2000);
            page.OpenYeaRound.SendKeys("Open Year Round");
            page.OffersRefundAdvance.SendKeys("Offers Refund Advance");
            page.OfficeInfo.Click();
            Thread.Sleep(2000);
            page.TrafficMap.Click();
            Thread.Sleep(3000);
            page.BackResults.Click();
            Thread.Sleep(3000);
            page.MakeAnAppointment.Click();
            driver.SwitchTo().Frame(0);
            Thread.Sleep(3000);
            page.CloseiFrame.Click();
            driver.SwitchTo().Frame(0).Quit();

        }
        [Test]
        public void MakeAnAppointment()

        {
           
           CoconutCalendarObjectsPage page = new CoconutCalendarObjectsPage(this.driver);
            page.FindAnOfficeNearYOu.Click();




            Thread.Sleep(2000);
            page.ALL.SendKeys("All");
            page.Walmart.SendKeys("Walmart");
            Thread.Sleep(2000);
            page.OpenYeaRound.SendKeys("Open Year Round");
            page.OffersRefundAdvance.SendKeys("Offers Refund Advance");
            page.OfficeInfo.Click();
            Thread.Sleep(2000);
            page.TrafficMap.Click();
            Thread.Sleep(3000);
            page.BackResults.Click();
            Thread.Sleep(3000);
            page.MakeAnAppointment.Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(0);
            //if (page.Next.Text == "Next")
            //{
            //    Console.WriteLine("Botton Founded: Test Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Button not found: Test Failed");
            //}

            var test = page.Next.Text;
            Assert.AreEqual(page.Next.Displayed, "NEXT");
            Console.WriteLine("Button Found");

            if (page.Next.Text == "Next")
            {
                Console.WriteLine("Botton Founded: Test Passed");
            }
            else
            {
                Console.WriteLine("Button not found: Test Failed");
            }

            page.Next.Click();
            page.ChooseTime.Click();
            Thread.Sleep(3000);
            page.Next_.Click();
            page.FirstName.SendKeys("Kit");
            page.LastName.SendKeys("Kat");
            page.Email.SendKeys("Faizul.islam@jtax.com");
            page.Mobile.SendKeys("2125555555");
            page.LastFourSSN.SendKeys("0123");
            page.TextReminder.Click();
            page.Notes.SendKeys("2016 tax fill");
            page.BookAppointment.Click();
            Thread.Sleep(5000);
        }
        public void FooMethod()
        {
            var firingDriver = new EventFiringWebDriver(new FirefoxDriver());
            firingDriver.ExceptionThrown += firingDriver_TakeScreenshotOnException;

            driver = firingDriver;
            driver.Navigate().GoToUrl("http://yizeng.me");

            // try find a non-existent element where NoSuchElementException should be thrown
            driver.FindElement(By.CssSelector("#some_id .foo")); // a screenshot should be taken automatically
        }

        private void firingDriver_TakeScreenshotOnException(object sender, WebDriverExceptionEventArgs e)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            driver.TakeScreenshot().SaveAsFile("Exception-" + timestamp + ".png", ImageFormat.Png);
        }




        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }



    }
}

