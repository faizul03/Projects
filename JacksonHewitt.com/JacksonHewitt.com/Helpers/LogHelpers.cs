using JacksonHewittFramework.com.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static System.Net.WebRequestMethods;
using System.IO;

namespace JacksonHewittFramework.com.Helpers
{
    public class LogHelpers
    {
        //Global Declaration
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;

        //Create a file which can store the log information
        public static void CreateLogFile()
        {
            string dir = Settings.LogPath;
            if (Settings.FileCreated == false)
                if (Directory.Exists(dir))
                {
                    Settings.FileCreated = true;
                    _streamw = System.IO.File.AppendText(dir + _logFileName + ".log");
                }
                else
                {
                    Settings.FileCreated = true;
                    Directory.CreateDirectory(dir);
                    _streamw = System.IO.File.AppendText(dir + _logFileName + ".log");
                }
        }



        //Create a method which can write the text in the log file
        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("    {0}", logMessage);
            _streamw.Flush();
        }


    }
}
