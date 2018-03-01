using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Appointment_Scheduling_Office_Locator
{
    class Office_Locator__EAPage_POM
    {
        public Office_Locator__EAPage_POM(IWebDriver driver)

        {
            PageFactory.InitElements(driver, this);
        }
        // Homepage Office Locator by Zipcode

       /// <summary>
       /// Search office from JacksonHewitt.com by zip code
       /// </summary>
       

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeText']")]
        public IWebElement EnterCity_State_Zip { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeButton']")]
        public IWebElement Find_A_Office_NearYOu { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='resultsList']/div[3]/p[2]/a")]
        public IWebElement Make_An_Appointment { get; set; }



        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[5]/td[4]/a")]
        public IWebElement Appointment_Day_Time { get; set; }




        [FindsBy(How =How.XPath,Using = ".//*[@id='apptTime15']")]
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

        [FindsBy(How =How.XPath,Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']")]
        public IWebElement Confirm_Appointment { get; set; }


        ///  <summary>
        ///  Verify that the apportment was schedule on JHnet
        ///  </summary>
        

          [FindsBy(How =How.XPath,Using = ".//*[@id='Username']")]
          public IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='Password']")]
        public IWebElement Password { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='btnSubmit']")]
        public IWebElement Login { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='_ctl5__ctl4_Navigation__ctl2']/span/span")]
        public IWebElement eService { get; set; }

        [FindsBy(How =How.XPath,Using = "//*[@id='Content_Template']/table/tbody/tr/td[2]/table[1]/tbody/tr[2]/td/div/table/tbody/tr/td[1]/ul/ul[1]/li[2]/a")]
        public IWebElement AppointmentScheduler { get; set; }
        [FindsBy(How =How.XPath,Using = "//*[@id='Content_PCenter']")]
        public IWebElement PCenter { get; set; }
        [FindsBy(How =How.XPath,Using = "//*[@id='Content_OfficeGrid']/tbody/tr[23]/td[1]/a")]
        public IWebElement Location { get; set; }
        [FindsBy(How =How.XPath,Using = "//*[@id='Content_Fieldsection1_RadDatePicker1_popupImage']")]
        public IWebElement Date { get; set; }
        [FindsBy(How =How.XPath,Using = "//*[@id='Content_Fieldsection1_RadDatePicker1_calendar_Top']/tbody/tr[7]/td[1]/a")]
        public IWebElement _Date { get; set; }

        [FindsBy(How =How.XPath,Using = "//*[@id='Content_Fieldsection1_ScheduleGrid_Grid']/tbody/tr[5]/td[2]/div/a")]
        
        public IWebElement AppointmentSummary { get; set; }

        [FindsBy(How=How.XPath,Using = "//*[@id='user']/a[2]")]
        public IWebElement Logout { get; set; }

        /// <summary>
        /// Search office from JacksonHewitt.com by City 
        /// </summary>

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeText']")]
        public IWebElement EnterCity_State_Zip_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeButton']")]
        public IWebElement Find_A_Office_NearYOu_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[5]/p[2]/a")]
        public IWebElement Make_An_Appointment_ { get; set; }



        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[5]/td[4]/a")]
        public IWebElement Appointment_Day_Time_ { get; set; }




        [FindsBy(How = How.XPath, Using = ".//*[@id='apptTime1']")]
        public IWebElement select_A_timeslot_ { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_purpose']")]
        public IWebElement Purpose_of_Appuintment_ { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_firstname']")]
        public IWebElement FirstName_ { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_lastname']")]
        public IWebElement LastName_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_telephone']")]
        public IWebElement TelePhone_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_email']")]
        public IWebElement Email_;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_last4']")]
        public IWebElement Last_Four_SSN_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_source']")]
        public IWebElement Source_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[8]/label")]
        public IWebElement Text_Message_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_comments']")]
        public IWebElement Additional_Comments_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']")]
        public IWebElement Confirm_Appointment_ { get; set; }


        ///  <summary>
        ///  Verify that the apportment was schedule on JHnet
        ///  </summary>
        ///  



        /// <summary>
        /// Search office by State on JacksonHewitt.com office locator. 
        /// </summary>

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeText']")]
        public IWebElement EnterCityStateZip { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeButton']")]
        public IWebElement FindAOfficeNearYOu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[2]/a")]
        public IWebElement MakeAnAppointment { get; set; }



        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[5]/td[4]/a")]
        public IWebElement AppointmentDayTime { get; set; }




        [FindsBy(How = How.XPath, Using = ".//*[@id='apptTime1']")]
        public IWebElement selectAtimeslot { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_purpose']")]
        public IWebElement PurposeofAppuintment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_firstname']")]
        public IWebElement First_Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_lastname']")]
        public IWebElement Last_Name { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_telephone']")]
        public IWebElement _TelePhone { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_email']")]
        public IWebElement _Email;

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_last4']")]
        public IWebElement LastFourSSN { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_source']")]
        public IWebElement _Source { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[10]/label")]
        public IWebElement TextMessage { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_comments']")]
        public IWebElement AdditionalComments { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']")]
        public IWebElement ConfirmAppointment { get; set; }


        // Office Locator under File Online 

        [FindsBy(How = How.Name, Using = ".//*[@id='secondaryFindOfficeText']")]
        public IWebElement EnterCity_State_Zip1 { get; set; }

        

        [FindsBy(How = How.XPath, Using = ".//*[@id='secondaryFindOffice']")]
        public IWebElement submit1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[2]/a")]
        public IWebElement Make_An_Appointment2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[5]/td[5]/a.//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[5]/td[5]/a")]
        public IWebElement Appointment_Day_Time2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='apptTime0']")]
        public IWebElement select_A_timeslot2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_purpose']")]
        public IWebElement Purpose_of_Appuintment2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_firstname']")]
        public IWebElement FirstName2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_lastname']")]
        public IWebElement LastName2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_telephone']")]
        public IWebElement TelePhone2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_email']")]
        public IWebElement Email2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_last4']")]
        public IWebElement Last_Four_SSN2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_source']")]
        public IWebElement Source2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[10]/label")]
        public IWebElement Text_Message2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_comments']")]
        public IWebElement Additional_Comments2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']")]
        public IWebElement Confirm_Appointment2 { get; set; }


        // Office Locator under the Free Federal Return Online 

        [FindsBy(How = How.XPath, Using = ".//*[@id='file-in-store-or-online']/div[5]/div/a")]
        public IWebElement Get_Started1 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOffice']")]
        public IWebElement Find_A_Office_NearYOu3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='locatorFilter']/div/div[1]/label")]
        public IWebElement All { get; set; }

        [FindsBy(How = How.Name, Using = "//*[@id='locatorFilter']/div/div[4]")]
        public IWebElement EnterCity_State_Zip3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='lbSearch']")]
        public IWebElement submit2 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[2]/a")]
        public IWebElement Make_An_Appointment3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_RadCalendar1_Top']/tbody/tr[4]/td[3]/a")]
        public IWebElement Appointment_Day_Time3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='apptTime3']")]
        public IWebElement select_A_timeslot3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_purpose']")]
        public IWebElement Purpose_of_Appuintment3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_firstname']")]
        public IWebElement FirstName3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_lastname']")]
        public IWebElement LastName3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_telephone']")]
        public IWebElement TelePhone3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_email']")]
        public IWebElement Email3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_last4']")]
        public IWebElement Last_Four_SSN3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_source']")]
        public IWebElement Source3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[10]/label")]
        public IWebElement Text_Message3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_comments']")]
        public IWebElement Additional_Comments3 { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ConfirmButton']")]
        public IWebElement Confirm_Appointment3 { get; set; }






    }
}
