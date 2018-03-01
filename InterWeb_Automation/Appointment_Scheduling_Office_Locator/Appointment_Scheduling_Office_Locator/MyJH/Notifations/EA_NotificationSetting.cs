using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Appointment_Scheduling_Office_Locator.MyJH.Notifations
{
    class EA_NotificationSetting
    {
        public EA_NotificationSetting(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
       [FindsBy(How =How.XPath,Using = ".//*[@id='ctl00_HeaderNavLoginLink']")]
       public IWebElement Login { get; set; }
       [FindsBy(How =How.XPath,Using = ".//*[@id='Username']")]
       public IWebElement UserName { get; set; }
        [FindsBy(How =How.XPath,Using = ".//*[@id='Password']")]
        public IWebElement Password { get; set; }
        [FindsBy(How =How.XPath,Using = ".//*[@id='sign-in']/div[5]")]
        public IWebElement SignIn { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='AccessCode']")]
        public IWebElement AccessCode { get; set; }

        //*[@id="AccessCode"]
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/form/fieldset/div[2]")]
        public IWebElement Continue { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='ctl00_mainContentPlaceHolder_myjhnav1_mvMyJHNav_HyperLink1_0'][@href='/MyJH/NotificationSettings/']")]
        public IWebElement NotificationSettings { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[2]/div[2]/ul/li[1]/label")]
        public IWebElement Email { get; set; }
        [FindsBy(How =How.XPath,Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[2]/div[2]/ul/li[2]/label")]
        public IWebElement SMS_TextMessage { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_txtMobileNumber']")]
        public IWebElement PhoneNumber { get; set; }
        [FindsBy(How =How.XPath,Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_imbSubmit']")]
        public IWebElement Submit { get; set; }

        
        

    
       
   

    }
    
}
