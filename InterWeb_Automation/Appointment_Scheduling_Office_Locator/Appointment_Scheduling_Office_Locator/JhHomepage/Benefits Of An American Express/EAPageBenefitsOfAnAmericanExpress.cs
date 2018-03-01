using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Appointment_Scheduling_Office_Locator.JhHomepage.Benefits_Of_An_American_Express
{
    class EAPageBenefitsOfAnAmericanExpress
    {
        public EAPageBenefitsOfAnAmericanExpress(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_CB']/div[3]/div[2]/div[3]/a")]
        public IWebElement BenefitsOfAnAmericanExpress { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeGeolocation']")]
        public IWebElement UseCurrentLocation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[5]/p[2]/a")]
        public IWebElement MakeAnAppointment { get; set; }



        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[5]/td[4]/a")]
        public IWebElement AppointmentDayTime { get; set; }




        [FindsBy(How = How.XPath, Using = ".//*[@id='apptTime1']")]
        public IWebElement selectAtimeslot { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_purpose']")]
        public IWebElement PurposeofAppuintment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_firstname']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_lastname']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_telephone']")]
        public IWebElement TelePhone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_email']")]
        public IWebElement Email;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_last4']")]
        public IWebElement LastFourSSN { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_source']")]
        public IWebElement Source { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[8]/label")]
        public IWebElement TextMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_comments']")]
        public IWebElement AdditionalComments { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']")]
        public IWebElement ConfirmAppointment { get; set; }

    }
}






