using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonHewitt_.Expired_Promo
{
    class ExpiredPromoPage
    {
        public ExpiredPromoPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }

        // Expired Promo

        [FindsBy(How = How.Id, Using = "signUpFirstName")]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "signUpEmailAddress")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "signUpSubmit")]
        public IWebElement signMeup { get; set; }



        // Use Current Location

        [FindsBy(How = How.Id, Using = "findOfficeGeolocation")]
        public IWebElement usecurrentLocation{ get; set; }


        [FindsBy(How = How.XPath, Using = (".//*[@id='resultsList']/div[3]/p[3]/a"))]
        public IWebElement officeInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='javascript:void()']")]
        public IWebElement trafficMap { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/ul/li[1]/a")]
        public IWebElement backtoResults { get; set; }

        [FindsBy(How = How.Id, Using = "searchfilter")]
        public IWebElement filterBy { get; set; }

        //[FindsBy(How = How.XPath, Using = (".//*[@id='resultsList']/div[3]/p[3]/a"))]
        //public IWebElement _officeInfo { get; set; }

        //[FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='javascript:void()']")]
        //public IWebElement _trafficMap { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/ul/li[1]/a")]
        //public IWebElement _backtoResults { get; set; }

        //[FindsBy(How = How.Id, Using = "searchfilter")]
        //public IWebElement _filterBy { get; set; }
        //[FindsBy(How = How.XPath, Using = (".//*[@id='resultsList']/div[3]/p[3]/a"))]
        //public IWebElement officeInfo_ { get; set; }

        //[FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='javascript:void()']")]
        //public IWebElement trafficMaP_ { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/ul/li[1]/a")]
        //public IWebElement backtoResults_ { get; set; }


        // Fina A Location 

        [FindsBy(How = How.XPath, Using = ".//*[@id='findOffice']")]
        public IWebElement findLoacation { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='txtZip']")]
        public IWebElement entercitystateorZip { get; set; }

        [FindsBy(How = How.Id, Using = "lbSearch")]
        public IWebElement Search { get; set; }
        //[FindsBy(How = How.Id, Using = "searchfilter")]
        //public IWebElement filterBy_ { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[3]/a")]
        //public IWebElement OfficeInfo { get; set; }

        //[FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='javascript:void()']")]
        //public IWebElement Trafficmap { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/ul/li[1]/a")]
        //public IWebElement Backtoresults { get; set; }



        //[FindsBy(How = How.Id, Using = "searchfilter")]
        //public IWebElement FilterBy { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[3]/a")]
        //public IWebElement officeinfo { get; set; }

        //[FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='javascript:void()']")]
        //public IWebElement trafficmap { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/ul/li[1]/a")]
        //public IWebElement backtoresults { get; set; }



        //[FindsBy(How = How.Id, Using = "searchfilter")]
        //public IWebElement FilterBY { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[3]/a")]
        //public IWebElement OfficeINFO { get; set; }

        //[FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='javascript:void()']")]
        //public IWebElement TrafficMAP { get; set; }

        //[FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/ul/li[1]/a")]
        //public IWebElement BackToResults { get; set; }





        /// <summary>
        /// Offer refund advnce  
        ///  This offer ended.
        /// </summary>

        // [FindsBy(How = How.Id, Using = "searchfilter")]
        // public IWebElement filterBY { get; set; }

        //  [FindsBy(How = How.XPath, Using = ".//*[@id='resultsList']/div[3]/p[3]/a")]
        //  public IWebElement officeINFO { get; set; }
        //
        //  [FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='javascript:void()']")]
        // public IWebElement trafficMAP { get; set; }

        // [FindsBy(How = How.XPath, Using = ".//*[@id='office-details']/div[2]/div[1]/ul/li[1]/a")]
        // public IWebElement backToResults { get; set; }









    }
}
//


