using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonWewitt_.ModalNewsletter
{
    class ModalObjectPage

    {


        public ModalObjectPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//*[@id='signUpFirstName']")]
        public IWebElement EnterFirstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='signUpEmailAddress']")]
        public IWebElement EnterEmailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='signUpForm']/p[3]")]
        public IWebElement SignMeUp { get; set; }




    }
}
