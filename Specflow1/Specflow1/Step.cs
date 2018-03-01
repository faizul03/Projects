
using System;
using TechTalk.SpecFlow;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed ass button");
           // ScenarioContext.Current.Pending();
           }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 121)
                Console.WriteLine("The test passed");
            else
            {
                Console.WriteLine("The test failed");
                //throw new Exception("The value is different");
                //ScenarioContext.Current.Pending();
            }
        }
    }
}

