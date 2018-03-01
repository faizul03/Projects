using JacksonHewittFramework.Base;
using JacksonHewittFramework.com.Config;
using JacksonHewittFramework.com.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;


namespace JacksonHewitt.com.Hooks
{

    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        [BeforeFeature]
        public static void TestStart()
        {
            InitializeSettings();
            Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
        }

        [AfterScenario]
        public void TestStop()
        {
            DriverContext.Driver.Quit();
        }

    }
}
