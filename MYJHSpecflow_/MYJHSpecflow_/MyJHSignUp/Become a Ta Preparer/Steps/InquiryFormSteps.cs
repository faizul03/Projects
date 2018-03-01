using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MYJHSpecflow_
{
    [Binding]
    public class InquiryFormSteps
    {
        private IWebDriver driver;
        [Given(@"that I am a Web user")]
        public void GivenThatIAmAWebUser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ss-test2.jacksonhewitt.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);

            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I navigate to the become a tax preparer link from the home page")]
        public void WhenINavigateToTheBecomeATaxPreparerLinkFromTheHomePage()
        {
            IWebElement BecomeaTaxPreparer = driver.FindElement(By.XPath(".//*[@id='utility-nav']//a[@href='/Our-Story/Become-Part-of-Our-Story/Become-a-Tax-Pro/']"));
            BecomeaTaxPreparer.Click();

            IWebElement Inquiryform = driver.FindElement(By.XPath("//ul[@class='list-unstyled']//a[@href='/Our-Story/Become-Part-of-Our-Story/Become-a-Tax-Pro/Learn-Tax-Preparation/']"));
            Inquiryform.Click();
           
            

           // ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to complete and submit inquiry  by providing the following information (.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)and(.*)")]
        public void ThenIShouldBeAbleToCompleteAndSubmitInquiryByProvidingTheFollowingInformationAndandandandandandandandandandand(string FirstName, string LastName, string StreetAddresss, string City, string ZipCode, string State, string ContactNumber, string Email, string ReEnterEmail, string AboutJacksonHewitt, string Specify, string InterestInJacksonHewitt)
        {
            IWebElement Firstname = driver.FindElement(By.XPath(".//*[@id='firstName']"));
            Firstname.SendKeys(FirstName);

            IWebElement Lastname = driver.FindElement(By.XPath(".//*[@id='lastName']"));
            Lastname.SendKeys(LastName);

            IWebElement Streetaddress = driver.FindElement(By.XPath(".//*[@id='address']"));
            Streetaddress.SendKeys(StreetAddresss);

            IWebElement city = driver.FindElement(By.XPath(".//*[@id='city']"));
            city.SendKeys(City);

            IWebElement Zipcode = driver.FindElement(By.XPath(".//*[@id='zip']"));
            Zipcode.SendKeys(ZipCode);

            IWebElement state = driver.FindElement(By.XPath(".//*[@id='state']"));
            state.SendKeys(State);

            IWebElement PhoneNumber = driver.FindElement(By.XPath(".//*[@id='phone']"));
            PhoneNumber.SendKeys(ContactNumber);

            IWebElement EMAIL = driver.FindElement(By.XPath(".//*[@id='email']"));
            EMAIL.SendKeys(Email);

            IWebElement REenteremail = driver.FindElement(By.XPath(".//*[@id='email2']"));
            REenteremail.SendKeys(ReEnterEmail);

            IWebElement Aboutjacksonhewitt = driver.FindElement(By.XPath(".//*[@id='howDidYouLearn']"));
            Aboutjacksonhewitt.SendKeys(AboutJacksonHewitt);

            IWebElement specify = driver.FindElement(By.XPath(".//*[@id='specify']"));
            specify.SendKeys(Specify);

            IWebElement interestinJacksonHewitt = driver.FindElement(By.XPath(".//*[@id='describes']"));
            interestinJacksonHewitt.SendKeys(InterestInJacksonHewitt);




            //ScenarioContext.Current.Pending();
        }

        
        [Then(@"I should be shown the thank you page")]
        public void ThenIShouldBeShownTheThankYouPage()
        {
            IWebElement Send = driver.FindElement(By.XPath(".//*[@id='learnTaxPrepSubmit']"));
            Send.Click();
            //ScenarioContext.Current.Pending();
            //System.Threading.Thread.Sleep(5000); // either or will work 
            Thread.Sleep(7000);

            driver.Quit();

        }
    }
}
