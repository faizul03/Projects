using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using JacksonHewitt_.Expired_Promo;

[TestFixture]
public class ExpiredPromo
{
    private OpenQA.Selenium.IWebDriver driver;
    [SetUp]
    public void Initialize()
    {
        driver = new ChromeDriver();
        // driver = new InternetExplorerDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://ss-test2.jacksonhewitt.com/expired-promo/");
        driver.Manage().Timeouts(). ImplicitWait=TimeSpan.FromSeconds(5);

        Console.WriteLine(driver.Url);
        Console.WriteLine(driver.Title);

    }
    [Test]
    public void SignMeUp()
    {
        ExpiredPromoPage page = new ExpiredPromoPage(this.driver);
        page.firstName.SendKeys("Test");
        page.emailAddress.SendKeys("Test@gmail.com");
        page.signMeup.Click();

        var testme = page.signMeup.Text;

        // check to if the SignUp button  exists
        Assert.AreEqual(page.signMeup.Text, "Sign Me Up!");
        Console.WriteLine("Test Passed");
        //Console.WriteLine("Assert: Sign Me Up!\r\nI agree to receiving emails from Jackson Hewitt");




    }
    [Test]

    public void UseCurrentLocation()
    {
        ExpiredPromoPage page = new ExpiredPromoPage(this.driver);

        page.usecurrentLocation.Click();
        Thread.Sleep(5000);
     
       // SendKeys.SendWait(@"{Enter}");
        var Button = page.usecurrentLocation.Text;
        

        // check to if the SignUp button  exists
        Assert.AreEqual(page.usecurrentLocation.Text, "USE CURRENT LOCATION");
        Console.WriteLine("Test Passed");

        if (page.usecurrentLocation.Text == "USE CURRENT LOCATION")
        {
            Console.WriteLine("Button found: Test Pass");
        }
        else
        {
            Console.WriteLine("Button was not found: Test Fail");
        }
        Thread.Sleep(3000);


        page.officeInfo.Click();
        Thread.Sleep(3000);
        page.trafficMap.Click();
        Thread.Sleep(3000);
        page.backtoResults.Click();


        page.filterBy.SendKeys("All");
        page.officeInfo.Click();
        Thread.Sleep(3000);
        page.trafficMap.Click();
        Thread.Sleep(3000);
        page.backtoResults.Click();

        page.filterBy.SendKeys("Walmart");
        Thread.Sleep(2000);
        page.officeInfo.Click();
        Thread.Sleep(2000);
        page.trafficMap.Click();
        Thread.Sleep(2000);
        page.backtoResults.Click();




    }
    [Test]
    public void FinaAOffice()

    {
        ExpiredPromoPage Page = new ExpiredPromoPage(this.driver);


        Thread.Sleep(3000);
        // check to if the SignUp button  exists
        var elem = Page.findLoacation.Text;
        Assert.AreEqual(Page.findLoacation.Text, "FIND A LOCATION");
        Console.WriteLine("Test Passed");
        if (Page.findLoacation.Text == "FIND A LOCATION")
        {
            Console.WriteLine("Button found: Test Pass");
        }
        else
        {
            Console.WriteLine("Button was not found");
        }

        Page.findLoacation.Click();
        Thread.Sleep(3000);
        Page.entercitystateorZip.SendKeys("72211");
        Page.Search.Click();
        Thread.Sleep(2000);
        Page.filterBy.SendKeys("All");
        Thread.Sleep(3000);



        Page.officeInfo.Click();
        Thread.Sleep(3000);
        Page.trafficMap.Click();
        Thread.Sleep(3000);
        Page.backtoResults.Click();
        Thread.Sleep(3000);


        //PAGE.FilterBy.SendKeys("Walmart");
        //Thread.Sleep(3000);
        //PAGE.officeinfo.Click();
        //Thread.Sleep(3000);
        //PAGE.trafficmap.Click();
        //Thread.Sleep(3000);
        //PAGE.backtoresults.Click();
        //Thread.Sleep(3000);


        //PAGE.FilterBY.SendKeys("Open Year Round");
        //Thread.Sleep(3000);

        ////PAGE.OfficeINFO.Click();
        ////Thread.Sleep(3000);
        ////PAGE.TrafficMAP.Click();
        ////Thread.Sleep(3000);
        ////PAGE.BackToResults.Click();







        /// <summary>
        /// Offer refund advnce  
        ///  this filter is not on test or staging yet.
        /// </summary>

        // PAGE.FilterBY.SendKeys("OFfer Refund Advance");
        // PAGE.OfficeINFO.Click();
        // PAGE.TrafficMAP.Click();
        // PAGE.BackToResults.Click();








    }

}
