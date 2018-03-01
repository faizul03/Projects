using JacksonHewittFramework.com.Config;
using JacksonHewittFramework.com.Helpers;

namespace JacksonHewittFramework.Base
{
    public abstract class BaseStep : Base
    {

        public virtual void NaviateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser !!!");
        }
    }
}
