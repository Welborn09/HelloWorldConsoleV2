using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldConsole;
using HelloWorldConsole.Services;
using System.Configuration;

namespace TestHelloWorld
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void Write_To_ConsoleTest()
        {
            var consoleService = new ConsoleService();
            var success = consoleService.WriteLine("Hello UT");
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Write_To_FileTest()
        {
            var consoleService = new ConsoleService();
            var success =consoleService.WriteLine("Hello FileUT");
            Assert.IsTrue(success);
        }
    }
}
