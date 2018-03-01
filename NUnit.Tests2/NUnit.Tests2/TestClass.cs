using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests2
{
    [TestFixture]
    public class BMICalculatorNUnitTest
    {
        IWebDriver driver;
        [SetUp]
        public void TestSetup()
        {
            // Create a instance of the Firefox driver using
            IWebDriver driver;
        driver = new FirefoxDriver();
        }
        [TestCaseSource("BmiTestData")]
        public void TestBmiCalculator(string height, string weight,
        string expected_bmi, string expected_category)
        {
            driver.Navigate().GoToUrl("http://dl.dropbox.com/u/55228056/mobilebmicalculator.html");

            IWebElement heightElement = driver.FindElement(By.Name("heightCMS"));
            heightElement.SendKeys(height);

            IWebElement weightElement = driver.FindElement(By.Name("weightKg"));
            weightElement.SendKeys(weight);

            IWebElement calculateButton = driver.FindElement(By.Id("Calculate"));

            calculateButton.Click();

            IWebElement bmiElement = driver.FindElement(By.Name("bmi"));

            Assert.AreEqual(expected_bmi, bmiElement.GetAttribute("value"));

            IWebElement bmiCatElement = driver.FindElement(By.Name("bmi_category"));
            Assert.AreEqual(expected_category, bmiCatElement.
            GetAttribute("value"));
        }
        [TearDown]
        public void TestCleanUp()
        {
            // Close the browser
            driver.Quit();
      

      
          
        }
    }
}