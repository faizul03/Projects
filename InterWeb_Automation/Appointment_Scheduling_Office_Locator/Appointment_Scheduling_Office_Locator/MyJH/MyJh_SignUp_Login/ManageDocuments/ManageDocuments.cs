using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Appointment_Scheduling_Office_Locator.MyJH.MyJh_SignUp_Login.MyJH
{
    [TestFixture]
    public class ManageDocuments
    {
        private IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5000));
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");
            Console.WriteLine(driver.Url);
            //Console.Read();
            Console.WriteLine(driver.Title);
            //Console.Read();

        }
        [Test]
        public void ManageDocument()
        {
           EAManageDocuments Page = new EAManageDocuments(this.driver);

            Page.LogInToMyJH.Click();
            Page.UserName.SendKeys("Test4jh16");
            Page.Password.SendKeys("Test4jh16!");
            Page.SignIn.Click();
            Page.AccessCode.SendKeys("correct");
            Page.Continue.Click();
            Page.ManageDocuments.Click();
            Page.UploadANewDocument.Click();
            Thread.Sleep(3000);
            Page.Upload.Click();
            Thread.Sleep(5000);
            SendKeys.SendWait("Desert.jpg");
            SendKeys.SendWait(@"{Enter}");


            Page.TaxYear.SendKeys("2015");
            Page.Category.SendKeys("Pay Stub");
            Page.Upload_.Click();
            SendKeys.SendWait(@"{Enter}");

        }
    
    [TearDown]
    public void EndTest()
    {
        driver.Quit();
    }

}
}
