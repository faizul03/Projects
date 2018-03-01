using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;


namespace Appointment_Scheduling_Office_Locator.MyJH.MyJh_SignUp_Login.MyJH
{
    class EAManageDocuments
    {

        public EAManageDocuments(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How =How.XPath,Using = ".//*[@id='ctl00_HeaderNavLoginLink']")]
        public IWebElement LogInToMyJH { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='Username']")]
        public IWebElement UserName { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='Password']")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@class='submitGroup']")]
        public IWebElement SignIn { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//*[@id='AccessCode']")]
        public IWebElement AccessCode { get; set; }
        
        [FindsBy(How =How.XPath,Using = "//*[@id='main']/form/fieldset/div[2]")]
       
 
        public IWebElement Continue { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@id='ctl00_mainContentPlaceHolder_myjhnav1_mvMyJHNav_HyperLink1_0'][@href='/MyJH/ManageDocs/']")]
        public IWebElement ManageDocuments { get; set; }
     

        [FindsBy(How = How.XPath,Using = "//a[@class='btn tertiary no-icon wrap'][@href='#upload']")]
        public IWebElement UploadANewDocument { get; set; }
  
        [FindsBy(How =How.XPath,Using = "//*[@id='ctl00_mainContentPlaceHolder_dzModal_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_upUploadDocuments']/div[1]/div")]

        public IWebElement Upload { get; set; }
        
        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzModal_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ddlTaxYear']")]
        public IWebElement TaxYear { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzModal_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_ddlCategory']")]
        public IWebElement Category { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_mainContentPlaceHolder_dzModal_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_btnSubmit']")]
        public IWebElement Upload_ { get; set; }

        


    }

    }

