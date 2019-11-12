using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole.Logging
{
    public class FileLog : Logger
    {
        public override void Log(string message)
        {
            string filePath = System.Environment.CurrentDirectory + @"\helloworld_log.txt";

            using (var streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
