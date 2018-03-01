using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduling_Office_Locator.MyJH.MyJh_SignUp_Login
{
    [TestFixture]
    public class JoinMyJH
    {
        private IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5000));
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/Join-My-JH//");
        }

        [Test]
        public void JoinMyJh()

        {
            EAPage_JoinMyJH Page = new EAPage_JoinMyJH(this.driver);
            Page.JoinMyJH.Click();
            Page.EMailAddress.SendKeys("faizul.islam@jtax.com");
            Page.ConfirmEmail.SendKeys("faizul.islam@jtax.com");
            Page.Create_UserName.SendKeys("Test4jh15");
            Page.Create_A_Password.SendKeys("Test4jh15!");
            Page.SecurityQuestion.SendKeys("What is your mother's name?");
            Page.EnterYourAnswer.SendKeys("Islam");
            Page.PhoneNumber.SendKeys("91473787283");
            Page.CreateAccount.Click();




            // TODO: Add your test code here
           // Assert.Pass("Your first passing test");
             }
        [TearDown]
            public void CleanUP()
        {
           // driver.Quit();
        }
        


        }
            

    }
