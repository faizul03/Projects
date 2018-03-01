using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JacksonWewitt_.OfficeLocator
{
    [TestFixture]
    public class OfficeLocator
    {
        private IWebDriver driver;
        [SetUp]
        public void Initialize()
        {

            //driver = new ChromeDriver();
            //driver = new FirefoxDriver(new FirefoxOptions());

            FirefoxProfile geoDisabled = new FirefoxProfile();
            geoDisabled.SetPreference("geo.enabled", false);
            geoDisabled.SetPreference("geo.provider.use_corelocation", false);
            geoDisabled.SetPreference("geo.prompt.testing", false);
            geoDisabled.SetPreference("geo.prompt.testing.allow", false);
            DesiredCapabilities capabilities = DesiredCapabilities.Firefox();
            capabilities.SetCapability(FirefoxDriver.ProfileCapabilityName, geoDisabled);
            driver = new FirefoxDriver();



            // driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ss-staging2.jacksonhewitt.com/");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);

        }
        [Test]
        public void FindOfficeByZip()
        {
            OfficeLocatorobjectsPage page = new OfficeLocatorobjectsPage(this.driver);

            page.entercitystateZip.SendKeys("72211");

            var test = page.findalocalOffice.Text;

            Assert.AreEqual(page.findalocalOffice.Text, "Find a local office");
            Console.WriteLine("Test Passed");

            if (page.findalocalOffice.Text == "Find a local office")
            {
                Console.WriteLine("Button found");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            page.findalocalOffice.Click();




            Thread.Sleep(2000);
            page.All.SendKeys("All");
            page.officeInfo.Click();
            Thread.Sleep(3000);
            page.trafficMap.Click();
            Thread.Sleep(3000);
            page.backtoResults.Click();
            Thread.Sleep(3000);
            page.Walmart.SendKeys("Walmart");
            page._officeInfo.Click();
            Thread.Sleep(3000);
            page._trafficMap.Click();
            Thread.Sleep(3000);
            page._backtoResults.Click();
            Thread.Sleep(2000);
            page.openyeaRound.SendKeys("Open Year Round");
            page.officeInfo_.Click();
            Thread.Sleep(3000); 
            page.trafficMap_.Click();
            Thread.Sleep(3000);
            page.backtoResults_.Click();


            /// <summary>
            /// Service turn off
            /// </summary>

            // page.offersrefundAdvance.SendKeys("Offers Refund Advance"); // Service turn off
            //  page.officeInfo.Click();
            //  Thread.Sleep(2000);
            //page.trafficMap.Click();
            //Thread.Sleep(3000);
            //page.backtoResults.Click();
            //Thread.Sleep(3000);
        }

        [Test]
        public void FindOfficeByCity()
        {
            OfficeLocatorobjectsPage page = new OfficeLocatorobjectsPage(this.driver);

            page.entercitystateZip.SendKeys("72211");

            var test = page.findalocalOffice.Text;

            Assert.AreEqual(page.findalocalOffice.Text, "Find a local office");
            Console.WriteLine("Test Passed");

            if (page.findalocalOffice.Text == "Find a local office")
            {
                Console.WriteLine("Button found");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            page.findalocalOffice.Click();


            // Fliter by and office info

            Thread.Sleep(2000);
            page.All.SendKeys("All");
            page.officeInfo.Click();
            page.trafficMap.Click();
            page.backtoResults.Click();
            page.Walmart.SendKeys("Walmart");
            page._officeInfo.Click();
            page._trafficMap.Click();
            page._backtoResults.Click();
            Thread.Sleep(2000);
            page.openyeaRound.SendKeys("Open Year Round");
            page.officeInfo_.Click();
            page.trafficMap_.Click();
            page.backtoResults_.Click();


            /// <summary>
            /// Service turn off
            /// </summary>

            // page.offersrefundAdvance.SendKeys("Offers Refund Advance"); // Service turn off
            //  page.officeInfo.Click();
            //  Thread.Sleep(2000);
            //page.TrafficMap.Click();
            //Thread.Sleep(3000);
            //page.BacktoResults.Click();
            //Thread.Sleep(3000);
        }
        [Test]
        public void FindOfficeByState()
        {
            OfficeLocatorobjectsPage page = new OfficeLocatorobjectsPage(this.driver);

            page.entercitystateZip.SendKeys("72211");

            var test = page.findalocalOffice.Text;

            Assert.AreEqual(page.findalocalOffice.Text, "Find a local office");
            Console.WriteLine("Test Passed");

            if (page.findalocalOffice.Text == "Find a local office")
            {
                Console.WriteLine("Button found");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            page.findalocalOffice.Click();




            Thread.Sleep(2000);
            page.All.SendKeys("All");
            page.officeInfo.Click();
            page.trafficMap.Click();
            page.backtoResults.Click();
            page.Walmart.SendKeys("Walmart");
            page.officeInfo.Click();
            page.trafficMap.Click();
            page.backtoResults.Click();
            Thread.Sleep(2000);
            page.openyeaRound.SendKeys("Open Year Round");
            page.officeInfo.Click();
            page.trafficMap.Click();
            page.backtoResults.Click();


            /// <summary>
            /// Service turn off
            /// </summary>

            // page.offersrefundAdvance.SendKeys("Offers Refund Advance"); // Service turn off
            //  page.officeInfo.Click();
            //  Thread.Sleep(2000);
            //page.trafficMap.Click();
            //Thread.Sleep(3000);
            //page.backtoResults.Click();
            //Thread.Sleep(3000);
        }



        [TearDown]
        public void cleanUp()
        {
            driver.Quit();
        }




    }
}
