using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Common
{
   public static class LoggingService
    {
        public static string LogAction(string action)
        {
            var logText = "Action: " + action;
            Console.WriteLine(logText);

            return logText;
        }
    }
}
