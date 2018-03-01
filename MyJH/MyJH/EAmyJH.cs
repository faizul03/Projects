using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace MyJH
{
    class EAmyJH
    {
        public EAmyJH (IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }
        
        [FindsBy(How =How.XPath, Using ="")]
        public IWebElement ;
        [FindsBy (How =How.XPath,Using = "")]


       


    }

}
