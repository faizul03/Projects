using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium.Firefox;

namespace Appointment_Scheduling_Office_Locator
{
    [TestClass]
    public class Office_Locator_TestCase


    {

        IWebDriver driver = new ChromeDriver();
       // IWebDriver driver = new FirefoxDriver();
        // There are 4 functionality associated with this Test Case NUnit Framework.
        // Each functionality had its own test case associated with it.
        //There are 4 office locator functionality In Jackson Hewitt homepage.

        [TestMethod]
        public void FindOfficeByZipcode()
        {
            //IWebDriver driver = new ChromeDriver();
            ExtentReports extent = new ExtentReports("C:\\Users\\islamf\\Documents\\Report\\Report.Html");
            var test = extent.StartTest("Test1", "Ofice Locator");

            test.Log(LogStatus.Info, "");

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

            Office_Locator__EAPage_POM page = new Office_Locator__EAPage_POM(this.driver);

            page.EnterCity_State_Zip.SendKeys("72211");
            var testme = page.Find_A_Office_NearYOu.Text;

            NUnit.Framework.Assert.AreEqual(page.Find_A_Office_NearYOu.Text, "FIND AN OFFICE NEAR YOU");
            Console.WriteLine("Assert:FIND AN OFFICE NEAR YOU");


            page.Find_A_Office_NearYOu.Click();
            page.Make_An_Appointment.Click();
            page.Appointment_Day_Time.Click();
            //driver.Navigate().Back();

           // Thread.Sleep(3000);
            page.select_A_timeslot.Click();
            page.Purpose_of_Appuintment.SendKeys("Start My Tax Return");
            page.FirstName.SendKeys("Faizul");
            page.LastName.SendKeys("Islam");
            page.TelePhone.SendKeys("9173047858");
            page.Email.SendKeys("faizul.islam@jtax.com");
            page.Last_Four_SSN.SendKeys("0147");
            page.Source.SendKeys("JacksonHewitt.com");
            page.Text_Message.Click();
            page.Additional_Comments.SendKeys("Hello World!");
            page.Confirm_Appointment.Click();

           Thread.Sleep(3000);
            extent.EndTest(test);
            extent.Flush();

        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();

        }
             [TestMethod]
        public void JHnetAppointment()
        {
            ExtentReports extent = new ExtentReports("C:\\Users\\islamf\\Documents\\Report\\Report.Html");
            var test = extent.StartTest("Test2", "Ofice Locator");

            test.Log(LogStatus.Info, "");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://test.jhnet.com/");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

            Office_Locator__EAPage_POM page = new Office_Locator__EAPage_POM(this.driver);
            page.Username.SendKeys("islamf");
            page.Password.SendKeys("express11.");
            page.Login.Click();
            page.eService.Click();
            Thread.Sleep(3000);
            page.AppointmentScheduler.Click();
            page.PCenter.SendKeys("EMY");
            page.Location.Click();
            Thread.Sleep(300);
            //page.Date.Click();
            page.Date.Click();
            page._Date.Click();
            Thread.Sleep(3000);
            page.AppointmentSummary.Click();
            page.Logout.Click();





            Thread.Sleep(3000);


            driver.Quit();
            extent.EndTest(test);
            extent.Flush();




        }
        [TestMethod]
        public void FindofficeByCity()
        {
            ExtentReports extent = new ExtentReports("C:\\Users\\islamf\\Documents\\Report\\Report.Html");
            var test = extent.StartTest("Test2", "Ofice Locator");

            test.Log(LogStatus.Info, "");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://ss-Test2.jacksonhewitt.com");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

            Office_Locator__EAPage_POM page = new Office_Locator__EAPage_POM(this.driver);

            //page.Get_Started.Click();
            //page.Find_A_Near_You_.Click();
          //  page.Select_State_on_the_Map.Click();
            page.EnterCity_State_Zip_.SendKeys("Sarasota,FL");
           // page.Find_A_Office_NearYOu1.Click();

            page.Find_A_Office_NearYOu_.Click();
            page.Make_An_Appointment_.Click();
            page.Appointment_Day_Time_.Click();
            page.select_A_timeslot_.Click();
            page.Purpose_of_Appuintment_.SendKeys("Start My Tax Return");
            page.FirstName_.SendKeys("Jimmy");
            page.LastName_.SendKeys("Jone");
            page.TelePhone_.SendKeys("5555555555");
            page.Email_.SendKeys("faizul.islam@jtax.com");
            page.Last_Four_SSN_.SendKeys("0147");
            page.Source_.SendKeys("JacksonHewitt.com");
            page.Text_Message_.Click();
            page.Additional_Comments_.SendKeys("Hello World!");
            page.Confirm_Appointment_.Click();

            Thread.Sleep(3000);


            driver.Quit();
            extent.EndTest(test);
            extent.Flush();
            { 
}

        }

        [TestMethod]
        public void FindOfficeByState()
        {
            ExtentReports extent = new ExtentReports("C:\\Users\\islamf\\Documents\\Report\\Report.Html");
            var test = extent.StartTest("Test2", "Ofice Locator");

            test.Log(LogStatus.Info, "");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

            Office_Locator__EAPage_POM page = new Office_Locator__EAPage_POM(this.driver);

            //page.Get_Started.Click();
            //page.Find_A_Near_You_.Click();
            //  page.Select_State_on_the_Map.Click();
            page.EnterCityStateZip.SendKeys("Florida");
            // page.Find_A_Office_NearYOu1.Click();
            page.FindAOfficeNearYOu.Click();
            page.MakeAnAppointment.Click();
            page.AppointmentDayTime.Click();
            page.selectAtimeslot.Click();
            page.PurposeofAppuintment.SendKeys("Start My Tax Return");
            page.First_Name.SendKeys("Jimmy");
            page.Last_Name.SendKeys("Jone");
            page._TelePhone.SendKeys("5555555555");
            page._Email.SendKeys("faizul.islam@jtax.com");
            page.LastFourSSN.SendKeys("0147");
            page._Source.SendKeys("JacksonHewitt.com");
            page.TextMessage.Click();
            page.AdditionalComments.SendKeys("Hello World!");
            page.ConfirmAppointment.Click();

            Thread.Sleep(3000);


            driver.Quit();
            extent.EndTest(test);
            extent.Flush();

        }
        [TestMethod]
        public void TestMethod4()
        {
             ExtentReports extent = new ExtentReports("C:\\Users\\islamf\\Documents\\Report\\Report.Html");
            var test = extent.StartTest("Test2", "Ofice Locator");

            test.Log(LogStatus.Info, "");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://ss-dev2.jacksonhewitt.com");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

          Office_Locator__EAPage_POM page = new Office_Locator__EAPage_POM(this.driver);
            page.Get_Started1.Click();
            page.Find_A_Office_NearYOu3.Click();
            page.EnterCity_State_Zip3.SendKeys("72211");
            page.submit2.Click();
            page.Make_An_Appointment3.Click();
            page.Appointment_Day_Time3.Click();
            page.select_A_timeslot3.Click();
            page.Purpose_of_Appuintment3.SendKeys("Start My Tax Return");
            page.FirstName3.SendKeys("Jimmy");
            page.LastName3.SendKeys("Jone");
            page.TelePhone3.SendKeys("5555555555");
            page.Email3.SendKeys("faizul.islam@jtax.com");
            page.Last_Four_SSN3.SendKeys("0147");
            page.Source3.SendKeys("JacksonHewitt.com");
            page.Text_Message3.Click();
            page.Additional_Comments3.SendKeys("Hello World!");
            page.Confirm_Appointment3.Click();

            Thread.Sleep(3000);


            driver.Quit();
            extent.EndTest(test);
            extent.Flush();

        }
    }
}