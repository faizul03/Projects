using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacksonHewitt_.BecomeATaxPreparer.InquiryForm
{
    class InquiryFormPage
    {
        //List all your element and name each mathod
        public InquiryFormPage(IWebDriver driver)

        {
            PageFactory.InitElements(driver, this);
        }
        // FindBy is nothing but Attribute 
        //Aattribute is use to covvey the information to runtime about the behaviors 


        //LEARN YOUR WAY – ON YOUR SCHEDULE 

        [FindsBy(How = How.XPath, Using = ".//*[@id='footer-nav']/ul/li[4]/ul/li[7]/a")]
        public IWebElement becomeaTaxPreparer { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@class='list-unstyled']//a[@href='/Our-Story/Become-Part-of-Our-Story/Become-a-Tax-Pro/Learn-Tax-Preparation/']")]
        public IWebElement inquiryForm { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='firstName']")]
        public IWebElement firstName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='lastName']")]
        public IWebElement lastName { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='address']")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='city']")]
        public IWebElement City { get; set; }
    
        [FindsBy(How = How.XPath, Using = ".//*[@id='zip']")]
        public IWebElement zipCode { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='state']")]
        public IWebElement State { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='phone']")]
        public IWebElement phoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email']")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='email2']")]
        public IWebElement reenteryourEmail { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='howDidYouLearn']")]
        public IWebElement learnaboutJacksonHewitt { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='specify']")]
        public IWebElement Specify { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='describes']")]
        public IWebElement Describes { get; set; }



        [FindsBy(How = How.XPath, Using = ".//*[@id='learnTaxPrepSubmit']")]
        public IWebElement Submit { get; set; }
    }
}