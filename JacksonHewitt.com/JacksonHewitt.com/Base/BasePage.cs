using OpenQA.Selenium.Support.PageObjects;

namespace JacksonHewittFramework.Base
{
    public abstract class BasePage : Base
{
    public BasePage()
    {
        PageFactory.InitElements(DriverContext.Driver, this);
    }

}
}
