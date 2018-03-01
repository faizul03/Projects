using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace JHModal_
{
    class EAModal
    {
        public EAModal(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How =How.XPath="")]
        public IWebElement 
    }
}
