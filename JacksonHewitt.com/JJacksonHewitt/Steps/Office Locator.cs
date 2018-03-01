using JacksonHewittFramework.Base;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace JacksonHewitt.Steps
{
    [Binding]
    internal class Office_Locator : BaseStep
    {
        [Given(@"I have Navigate to jackson Hewitt Hompage")]
        public void GivenIHaveNavigateToJacksonHewittHompage()
        {
            
            
            // ScenarioContext.Current.Pending();
            }
        

        [Given(@"I have entered (.*) and (.*) and (.*)")]
        public void GivenIHaveEnteredAndAnd(string p0, string p1, string p2, Table table)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I click find an office near you I should see list of offices")]
        public void WhenIClickFindAnOfficeNearYouIShouldSeeListOfOffices()
        {
            //ScenarioContext.Current.Pending();
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
