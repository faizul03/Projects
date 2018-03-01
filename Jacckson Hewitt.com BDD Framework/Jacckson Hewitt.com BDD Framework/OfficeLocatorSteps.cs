using Jacckson_Hewitt.com_BDD_Framework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Jacckson_Hewitt.com_BDD_Framework
{

    [Binding]

    public class OfficeLocatorSteps
    {
        private IWebDriver driver;
        OfficeLocator page = new OfficeLocator();

    
        
        [Given(@"I have Navigate to jackson Hewitt Hompage")]
        public void GivenIHaveNavigateToJacksonHewittHompage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ss-test2.jacksonhewitt.com");
            page.EnterCityStateZip.Click();
            
            
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered (.*) and (.*) and (.*)")]
        public void GivenIHaveEnteredAndAnd(string Zipcod, string State, string City, Table table)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I click find an office near you I should see list of offices")]
        public void WhenIClickFindAnOfficeNearYouIShouldSeeListOfOffices()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I should be able to Filter By")]
        public void WhenIShouldBeAbleToFilterBy()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"Ishould be able to view office deatil")]
        public void WhenIshouldBeAbleToViewOfficeDeatil()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}


