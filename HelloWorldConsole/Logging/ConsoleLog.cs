using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole.Logging
{
    public class ConsoleLog : Logger
    {
        public override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
