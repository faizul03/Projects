using System;
using TechTalk.SpecFlow;

namespace BDDTEST_
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        [When(@"User enter (.*)")]
        public void WhenUserEnter(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
