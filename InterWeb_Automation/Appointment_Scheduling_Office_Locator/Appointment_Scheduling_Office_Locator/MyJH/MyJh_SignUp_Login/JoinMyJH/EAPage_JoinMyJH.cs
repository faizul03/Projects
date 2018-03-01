using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduling_Office_Locator.MyJH.MyJh_SignUp_Login
{
    class EAPage_JoinMyJH
    {
       public EAPage_JoinMyJH(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_CB']/div/div[1]/p/a")]
        public IWebElement JoinMyJH { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='Email']")]
        public IWebElement EMailAddress { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='ConfirmEmail']")]
        public IWebElement ConfirmEmail { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='UserName']")]
        public IWebElement Create_UserName { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='Password']")]
        public IWebElement Create_A_Password { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='SecurityQuestion']")]
        public IWebElement  SecurityQuestion { set; get; }
        
        [FindsBy(How =How.XPath,Using = ".//*[@id='SecurityResponse']")]
        public IWebElement EnterYourAnswer { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='MobilePhone']")]
        public IWebElement PhoneNumber { get; set; }

        [FindsBy(How =How.XPath,Using = ".//*[@id='submitBtn']")]
        public IWebElement CreateAccount { get; set; }






    }
    
}
