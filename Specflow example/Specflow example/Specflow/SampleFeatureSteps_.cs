using Specflow_example;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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
                throw new Exception("The value is different");
                //ScenarioContext.Current.Pending();
            }
        }
        [When(@"I fill all the mandatory detail in form")]
        public void WhenIFillAllTheMandatoryDetailInForm(Table table)
        {
            //ScenarioContext.Current.Pending();
            var detail =  table.CreateSet<EmployeeDetails>();
            foreach (EmployeeDetails emp in detail)
            {
                Console.WriteLine("The Details of Employee :" + emp.Name);
                Console.WriteLine("***************************************");
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Email);
                Console.WriteLine(emp.Phone);
            
            }

           
        }

    }
}

