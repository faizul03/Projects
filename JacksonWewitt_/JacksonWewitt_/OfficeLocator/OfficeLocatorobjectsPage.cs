using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonWewitt_.OfficeLocator
{
    class OfficeLocatorobjectsPage
    {
         
        public OfficeLocatorobjectsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }
        // find a office 

        [FindsBy(How = How.XPath, Using = ".//*[@id='banner-location']")]
        public IWebElement entercitystateZip { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@class='banner-right-btn']")]
        public IWebElement findalocalOffice { get; set; }

        // Filter By 
        [FindsBy(How = How.XPath, Using = "//*[@id='searchfilter']")]
        public IWebElement All { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='resultsList']/div[3]/p[3]/a")]
        public IWebElement officeInfo { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[3]/a")]
        public IWebElement trafficMap { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[1]/a")]
        public IWebElement backtoResults { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='searchfilter']")]
        public IWebElement Walmart { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='resultsList']/div[3]/p[3]/a")]
        public IWebElement officeInfo_ { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[3]/a")]
        public IWebElement trafficMap_ { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[1]/a")]
        public IWebElement backtoResults_ { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='searchfilter']")]
        public IWebElement openyeaRound { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='resultsList']/div[3]/p[3]/a")]
        public IWebElement _officeInfo { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[3]/a")]
        public IWebElement _trafficMap { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[1]/a")]
        public IWebElement _backtoResults { get; set; }

        /// <summary>
        /// Service turn off
        /// </summary>
        //[FindsBy(How = How.XPath, Using = "//*[@id='searchfilter']")]
        //public IWebElement offersrefundAdvance { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='resultsList']/div[3]/p[3]/a")]
        //public IWebElement OfficeInfo { get; set; }


        //[FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[3]/a")]
        //public IWebElement TrafficMap { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/div[2]/ul/li[1]/a")]
        //public IWebElement BacktoResults { get; set; }








    }
}
