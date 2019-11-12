using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsole.Services;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleService = new ConsoleService();
            consoleService.WriteLine("Hello World");

            Console.ReadKey();
        }
    }
}
