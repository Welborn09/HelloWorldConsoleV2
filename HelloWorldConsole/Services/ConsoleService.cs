using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsole.Logging;
namespace HelloWorldConsole.Services
{
    public class ConsoleService : IConsole
    {
        public bool WriteLine(string message)
        {
            LogHelper.Log(message);
            return true;
        }
    }
}
