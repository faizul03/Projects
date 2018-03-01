using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://ss-test.jacksonhewitt.com/");
            IWebElement LogIn = driver.FindElement(By.XPath(".//*[@id='login']"));
            LogIn.Click();
            IWebElement Username = driver.FindElement(By.XPath(".//*[@id='Username']"));
            Username.SendKeys("Faizul85");
            IWebElement Password = driver.FindElement(By.XPath(".//*[@id='Password']"));
            Password.SendKeys("Express11!");
            IWebElement SignIn = driver.FindElement(By.XPath(".//*[@id='sign-in']/div[5]"));
            SignIn.Click();

            IWebElement ManageDocuments = driver.FindElement(By.XPath(".//*[@id='ctl00_ContentPlaceHolder1_myjhnav1_mvMyJHNav_HyperLink1_0']"));
            ManageDocuments.Click();

            IWebElement NewDoc = driver.FindElement(By.XPath(".//*[@id='ctl00_ContentPlaceHolder1_dzMainColumn_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']/div/div/div[2]/nav/ul/li[5]"));
            NewDoc.Click();
            IWebElement Upload = driver.FindElement(By.XPath(".//*[@id='ctl00_cphModals_dzModal_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_fileupload']]"));
            Upload.Click();
        }
    }
}
