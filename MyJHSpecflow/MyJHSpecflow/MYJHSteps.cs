using System;
using TechTalk.SpecFlow;

namespace MyJHSpecflow
{
    [Binding]
    public class MYJHSteps
    {
        [Given(@"User is at the Jackson Hewitt Home Page")]
        public void GivenUserIsAtTheJacksonHewittHomePage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Click on the Login button and enter access code")]
        public void WhenClickOnTheLoginButtonAndEnterAccessCode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successful Logot message should display")]
        public void ThenSuccessfulLogotMessageShouldDisplay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
