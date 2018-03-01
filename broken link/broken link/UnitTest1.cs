using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Net;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace broken_link
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        
        private void LoopLink()
        {
            int count = LinkElements.Count;
            

            for (int i = 0; i < count; i++)
            {
                driver.FindElements(By.TagName("a"))[i].Click();
                //some ways to come back to the previous page]

            }

        }
    }
}

