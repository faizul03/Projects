using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Runtime.Remoting.Messaging;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.Events;
using System.Threading;


///* <summary>
///  BDD is ruuning the test for office locator 
/// </summary>
/// Base on the Feature and user acceptance criteria.
/// Running one test with Multiple data 
/// Running one test with Multiple data (Data driven)
namespace Test_bdd
{
    [Binding]
    class Class1
    {
        private IWebDriver driver;
        [Given(@"I have Navigate to jackson Hewitt Hompage")]
        public void GivenIHaveNavigateToJacksonHewittHompage()
        {
            driver = new ChromeDriver();

            // driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Url = ("https://ss-dev2.jacksonhewitt.com");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);


            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered (.*)")]
        public void GivenIHaveEnteredzipcode(string Zipcode)

        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(".//div[@class='modal-header']//button[@class='close']")).Click();
            //IAlert alert = driver.SwitchTo().Alert();
            //Thread.Sleep(6000);
            //alert.Accept();
            //alert.Dismiss();


            IWebElement EnterCityStateZip = driver.FindElement(By.XPath(".//*[@id='findOfficeText']"));
            EnterCityStateZip.SendKeys(Zipcode);
            //IWebElement FindAOfficeNearYou = driver.FindElement(By.XPath(".//*[@id='findOfficeButton']"));
            // FindAOfficeNearYou.Click();


            // ScenarioContext.Current.Pending();
        }

        [When(@"I click find an office near you i should see list of offices")]
        public void WhenIClickFindAnOfficeNearYouIShouldSeeListOfOffices()
        {
            IWebElement FindAOfficeNearYou = driver.FindElement(By.XPath(".//*[@id='findOfficeButton']"));
            FindAOfficeNearYou.Click();
            //ScenarioContext.Current.Pending();
        }
        [When(@"I should be able to pick a office and create appointment")]
        public void WhenIShouldBeAbleToPickAOfficeAndCreateAppointment()
        {
            IWebElement MakeAnAppointment = driver.FindElement(By.XPath(".//*[@id='resultsList']/div[3]/p[2]/a"));
            MakeAnAppointment.Click();


            IWebElement AppointmentDayTime = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[5]/td[2]/a"));
            AppointmentDayTime.Click();

            IWebElement SelectAtimeslot = driver.FindElement(By.XPath(".//*[@id='apptTime2']"));
            SelectAtimeslot.Click();
        }
        [Then(@"I should be able to  fill out the form(.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)")]
        public void ThenIShouldBeAbleToFillOutTheFormAnd(string PurposeofAppointment, string FirstName, string LastName, string Telephone, string Email, string LastFourDigitsofSSN, string Source, string AdditionalComments)
        {

            IWebElement PurposeofAppuintment = driver.FindElement(By.XPath("//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_purpose']"));
            PurposeofAppuintment.SendKeys(PurposeofAppointment);

            IWebElement EnterFirstName = driver.FindElement(By.XPath("//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_firstname']"));
            EnterFirstName.SendKeys(FirstName);

            IWebElement EnterLastname = driver.FindElement(By.XPath("//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_lastname']"));
            EnterLastname.SendKeys(LastName);

            IWebElement EnterTelephone = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_telephone']"));
            EnterTelephone.SendKeys(Telephone);

            IWebElement EnterEmail = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_email']"));
            EnterEmail.SendKeys(Email);

            IWebElement EnterLastFourDigitsofSSN = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_last4']"));
            EnterLastFourDigitsofSSN.SendKeys(LastFourDigitsofSSN);

            IWebElement EnterSource = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_source']"));
            EnterSource.SendKeys(Source);

            IWebElement TextMessage = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[8]/label"));
            TextMessage.Click();

            IWebElement EnterAdditionalComments = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_comments']"));
            EnterAdditionalComments.SendKeys(AdditionalComments);

            IWebElement Confirm_Appointment = driver.FindElement(By.XPath(".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']"));
            Confirm_Appointment.Click();








        }
        //ScenarioContext.Current.Pending();

        [AfterScenario]
        public void cleanUp()
        {

            driver.Quit();
        }
    }
}
