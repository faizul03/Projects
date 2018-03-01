using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Scheduling_Office_Locator.ModalNewsletter
{
    [TestFixture]
    public class TestClass1
    {
        private IWebDriver driver;
        [SetUp]
        public void Initialize()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("https://ss-dev2.jacksonhewitt.com/");
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);
            driver.SwitchTo().ActiveElement();
            //driver.SwitchTo().Alert().Accept();





        }

        [Test]
        public void ModalNeg()
        {
          //EAModal page = new EAModal();
            //page.close.Click();






        }
    }
}
