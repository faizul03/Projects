using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JacksonHewitt_.BecomeATaxPreparer.InquiryForm
{

    [TestFixture]
    public class InquiryForm
    {
        private IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
        }
        [Test]
        public void Inquiryform()
        {
            InquiryFormPage page = new InquiryFormPage(this.driver);
            page.becomeaTaxPreparer.Click();
            page.inquiryForm.Click();
            page.firstName.SendKeys("Sam");
            page.lastName.SendKeys("Smith");
            page.Address.SendKeys("501 N Cattleman RD");
            page.City.SendKeys("Sarasota");
            page.zipCode.SendKeys("34202");
            page.State.SendKeys("FL");
            page.phoneNumber.SendKeys("5555555555");
            page.Email.SendKeys("faizul.islam@jtax.com");
            page.reenteryourEmail.SendKeys("faizul.islam@jtax.com");
            page.learnaboutJacksonHewitt.SendKeys("Trade Show");
            page.Specify.SendKeys("Expo");
            page.Describes.SendKeys("Other");
            Thread.Sleep(5000);
            page.Submit.Click();


            // TODO: Add your test code here
            //Assert.Pass("Your first passing test");
        }


        [TearDown]
        public void cleanup()
        {
            Thread.Sleep(5000);
            driver.Quit();


        }
    }

}
