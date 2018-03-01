using System;
using TechTalk.SpecFlow;

namespace Jackson_Hewitt_BDD_Framework
{
    [Binding]
    public class OfficeLocatorSteps
    {
        [Given(@"I have Navigate to jackson Hewitt Hompage")]
        public void GivenIHaveNavigateToJacksonHewittHompage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered (.*) and (.*) and (.*)")]
        public void GivenIHaveEnteredAndAnd(string p0, string p1, string p2, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click find an office near you I should see list of offices")]
        public void WhenIClickFindAnOfficeNearYouIShouldSeeListOfOffices()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I should be able to Filter By")]
        public void WhenIShouldBeAbleToFilterBy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Ishould be able to view office deatil")]
        public void WhenIshouldBeAbleToViewOfficeDeatil()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
