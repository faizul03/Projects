using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;

namespace Tets
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //IWebDriver driver= new ChromeDriver();
            IWebDriver driver = new FirefoxDriver();


            driver.Navigate().GoToUrl("https://test.jhnet.com");
          IWebElement Pcenter = driver.FindElement(By.XPath(".//*[@id='PCenter']"));
            Pcenter.SendKeys("zba");
            driver.FindElement(By.XPath(".//*[@id='Username']")).SendKeys("jhadmin");
            driver.FindElement(By.XPath(".//*[@id='Password']")).SendKeys("Test4jh!");
            driver.FindElement(By.XPath(".//*[@id='btnSubmit']")).Click();

            driver.FindElement(By.XPath(".//*[@id='_ctl5__ctl4_Navigation__ctl3']/span/span")).Click();
            Thread.Sleep(300);
            driver.FindElement(By.XPath(".//*[@id='Content_Template']/table/tbody/tr/td[2]/table[1]/tbody/tr[2]/td/div/table/tbody/tr/td[2]/ul/ul[5]/li/a")).Click();
            Thread.Sleep(5000);

            //table[@cellspacing='0']//td[@colspan='100%']//div[@id='Content_epop_divFreeType']//table[@style='MARGIN-TOP: 3px; PADDING-TOP: 0px']//td[@align='center']//input[@id='Content_epop_txtLocation']
            //driver.FindElement(By.XPath("")).Click();
            //driver.FindElement(By.XPath("//table[@cellspacing='0']//td[@colspan='100%']//div[@id='Content_epop_divFreeType']//table[@style='MARGIN-TOP: 3px; PADDING-TOP: 0px']//td[@align='center']//input[@id='Content_epop_txtLocation']")).Click();
            driver.FindElement(By.XPath("//div[@id='Content_epop_divFreeType']//table[@style='MARGIN-TOP: 3px; PADDING-TOP: 0px']//td[@align='center']//input[@id='Content_epop_txtLocation'][@name='_ctl0:Content:epop:txtLocation']")).SendKeys("5000");
            driver.FindElement(By.XPath(".//*[@id='Content_cmdReport']")).Click();
           




        }
    }
}
