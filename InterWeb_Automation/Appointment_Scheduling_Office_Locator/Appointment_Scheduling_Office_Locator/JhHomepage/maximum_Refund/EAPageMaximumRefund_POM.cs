using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Appointment_Scheduling_Office_Locator.maximum_Refund
{
    class EAPageMaximumRefund_POM
    {

        public EAPageMaximumRefund_POM(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_CB']/div[3]/div[2]/div[1]/a")]
        public IWebElement MaximumRefund { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeText']")]
        public IWebElement EnterCity_State_Zip { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeButton']")]
        public IWebElement Find_A_Office_NearYOu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[5]/p[2]/a")]
        public IWebElement Make_An_Appointment { get; set; }
       

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[6]/td[1]/a")]
        public IWebElement Appointment_Day_Time { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='apptTime3']")]
        public IWebElement select_A_timeslot { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_purpose']")]
        public IWebElement Purpose_of_Appuintment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_firstname']")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_lastname']")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_telephone']")]
        public IWebElement TelePhone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_email']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_last4']")]
        public IWebElement Last_Four_SSN { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_source']")]
        public IWebElement Source { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[8]/label")]
        public IWebElement Text_Message { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_comments']")]
        public IWebElement Additional_Comments { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']")]
        public IWebElement Confirm_Appointment { get; set; }




    }

   // [FindsBy(How = How.XPath,Using ="")];

    }

