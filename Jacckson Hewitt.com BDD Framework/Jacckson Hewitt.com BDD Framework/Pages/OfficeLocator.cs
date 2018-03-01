using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacckson_Hewitt.com_BDD_Framework.Pages
{
    class OfficeLocator
    {
        public OfficeLocator(IWebDriver driver)
            
        {
            PageFactory.InitElements(driver, this);
        }

        public OfficeLocator()
        {
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOfficeText']")]
        public IWebElement EnterCityStateZip { get; set; }


        [FindsBy(How = How.Id, Using = "findOfficeButton")]
        public IWebElement FindAnOfficeNearYOu { get; set; }

        // Filter By 
        [FindsBy(How = How.XPath, Using = "//*[@id='searchfilter']")]
        public IWebElement ALL { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchfilter']")]
        public IWebElement Walmart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchfilter']")]
        public IWebElement OpenYeaRound { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchfilter']")]
        public IWebElement OffersRefundAdvance { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='resultsList']/div[3]/p[3]/a")]
        public IWebElement OfficeInfo { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div/div[2]/div[1]/ul/li[3]/a")]
        public IWebElement TrafficMap { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_mainContentPlaceHolder_dzMain_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div/div[2]/div[1]/ul/li[1]/a")]
        public IWebElement BackResults { get; set; }

        // CocoNute Calendar iframe 

        [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[2]/a")]
        public IWebElement MakeAnAppointment { get; set; }

        //[FindsBy(How =How.XPath,Using = ".//*[@id='main']/div/div[3]/div/div[3]/a[1]/i")]
        //public IWebElement ChooseMonth { get; set; }

        // clicking next without any information.
        // Negative test

        [FindsBy(How = How.XPath, Using = ".//*[@id='footer']/div/div/div[3]/button")]
        public IWebElement ClickNext { get; set; }

        // Closing iframe 
        [FindsBy(How = How.XPath, Using = ".//*[@id='calendarModal']/div[1]/button")]
        public IWebElement CloseiFrame { get; set; }



        [FindsBy(How = How.XPath, Using = ".//*[@id='footer']/div/div/div[3]/button")]
        public IWebElement Next { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='main']/div/div[3]/div/div[4]/ul/li[5]/div[2]/div/ul/li[3]/a")]
        public IWebElement ChooseTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='l-buttons-right-button']//button[@class='button']")]
        public IWebElement Next_ { get; set; }



        [FindsBy(How = How.Id, Using = "first-name")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "last-name")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "cell-phone")]
        public IWebElement Mobile { get; set; }

        [FindsBy(How = How.Id, Using = "ssn")]
        public IWebElement LastFourSSN { get; set; }

        [FindsBy(How = How.Id, Using = "notify-sms")]
        public IWebElement TextReminder { get; set; }

        [FindsBy(How = How.Id, Using = "notes")]
        public IWebElement Notes { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='l-buttons-book-button']//button[@class='button']")]
        public IWebElement BookAppointment { get; set; }


        ///  <summary>
        ///  Verify that the apportment was schedule on JHnet
        ///  </summary>
    }

}
