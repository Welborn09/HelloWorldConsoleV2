using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorldConsole.Logging
{
    public static class LogHelper
    {
        private static Logger logger = null;

        public static void Log(string message)
        {
            var logType = GetConfigurationValue();

            switch (logType)
            {
                case "console":
                    logger = new ConsoleLog();
                    logger.Log(message);
                    break;

                case "file":
                    logger = new FileLog();
                    logger.Log(message);
                    break;

                default:
                    logger = new ConsoleLog();
                    logger.Log(message);
                    break;
            }
        }

        public static string GetConfigurationValue()
        {
            var appSettings = ConfigurationManager.AppSettings;

            return appSettings["LogType"].ToLower();
        }

    }
}
