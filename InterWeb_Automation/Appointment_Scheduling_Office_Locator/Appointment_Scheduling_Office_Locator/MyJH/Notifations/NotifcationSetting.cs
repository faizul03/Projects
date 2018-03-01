using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduling_Office_Locator.MyJH.Notifations
{
    [TestFixture]
    public class NotifcationSetting

    {
        private IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5000));
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");

        }
        [Test]
        public void Notification()
        {
            EA_NotificationSetting Page = new EA_NotificationSetting(this.driver);
            Page.Login.Click();
            Page.UserName.SendKeys("test4jh16");
            Page.Password.SendKeys("Test4jh16!");
            Page.SignIn.Click();
            Page.AccessCode.SendKeys("correct");
            Page.Continue.Click();
            Page.NotificationSettings.Click();
            Page.Email.Click();
            Page.SMS_TextMessage.Click();
            Page.PhoneNumber.SendKeys("9173047858");
            Page.Submit.Click();


            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
        
    }
}
