using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace Appointment_Scheduling_Office_Locator.ModalNewsletter
{
    class EAModal

    {
        public EAModal(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public EAModal()
        {
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='signUpFirstName']")]
        public IWebElement EnterFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='signUpEmailAddress']")]
        public IWebElement EnterEmailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='signUpForm']/p[3]")]
        public IWebElement SignMeUp { get; set; }

       // [FindsBy(How =How.CssSelector,Using  = "a.modalCloseImg")]
      //  public IWebElement close { get; set; }
    }
}
