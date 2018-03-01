using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Bindings;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;

namespace Specflow_BDD.Steps
{
    [Binding]
    class OfficeLocatorSteps
    {
        IWebDriver currentDriver = null;

        [Given(@"I have navigated to jh homepage")]
        public void GivenIhavenavigatedtojhofficelocator()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
        }

        [Given(@"I see the jh homepage fully loaded")]
        public void GivenISeeJhHomepageFullyLoaded()
        {
            if (currentDriver.FindElement(By.XPath("//*[@id='findOfficeText']")).Displayed == true)
                Console.WriteLine("page loaded fully");
            else
                Console.WriteLine("page fail to load");

                    }

        [When(@"I type search zipcode as")]
        public void WhenITypesearchzipcodeas(Table table)
        {
            dynamic tableDetail = table.CreateDynamicInstance();
            currentDriver.FindElement(By.XPath("//*[@id='findOfficeText']")).SendKeys(tableDetail.zipcode);
        }

        [Then(@"I should see the result for zipcode")]
        public void ThenIShouldseetheresultforzipcode(Table table)
        {
            dynamic tableDetail = table.CreateDynamicInstance();
            string key = tableDetail.zipcode;
            if (currentDriver.FindElement(By.XPath("//*[@id='findOfficeButton']")).Displayed == true)
                Console.WriteLine("control exist");
            else
                Console.WriteLine("Control not exist");
        }
            

        }

        }
        
    

