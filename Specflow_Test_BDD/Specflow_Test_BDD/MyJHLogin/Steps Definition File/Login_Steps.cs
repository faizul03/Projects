using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace Specflow_Test_BDD
{
    [Binding]
    public class Login_Steps
    {
        public IWebDriver driver;

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://ss-test2.jacksonhewitt.com/";
            IWebElement Login = driver.FindElement(By.XPath(".//*[@id='ctl00_HeaderNavLoginLink']"));
            Login.Click();

            //ScenarioContext.Current.Pending();
        }

        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            IWebElement Username = driver.FindElement(By.XPath(".//*[@id='Username']"));
            Username.SendKeys("test4jh16");
            IWebElement Password = driver.FindElement(By.XPath(".//*[@id='Password']"));
            Password.SendKeys("Test4jh16!");
            //ScenarioContext.Current.Pending();
        }

        [When(@"Click on the LogIn button and enter access code")]
        public void WhenClickOnTheLogInButton()
        {
            IWebElement Login = driver.FindElement(By.XPath(".//div[@class='submitGroup']//input[@id='submitBtn']"));
            Login.Click();
            IWebElement AccessCode = driver.FindElement(By.XPath("//*[@id='AccessCode']"));
            AccessCode.SendKeys("correct");

            IWebElement Continue = driver.FindElement(By.XPath(".//div[@class='submitGroup']//input[@id='submitBtn']"));
            Continue.Click();
            // ScenarioContext.Current.Pending();



        }

        [Then(@"Successful Logout message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            IWebElement LogOutDropDown = driver.FindElement(By.XPath(".//*[@id='my-jh']/label"));
            LogOutDropDown.Click();
            
            IWebElement LogOut = driver.FindElement(By.XPath(".//*[@id='dropdownAuthLink']"));
            LogOut.Click();
            Thread.Sleep(5000);
        }
       
           
            
          [AfterScenario]
        public void CleanUp()
        {
           
            driver.Quit();
            }
        }
    }

            //ScenarioContext.Current.Pending();
        
       
        
            //ScenarioContext.Current.Pending();
            // driver.Quit();
        

        
    


