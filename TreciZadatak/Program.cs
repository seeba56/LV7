using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider dataProvider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger fileLogger = new FileLogger("logger.txt");
            dataProvider.Attach(consoleLogger);
            dataProvider.Attach(fileLogger);

            while (1 < 2)
            {
                dataProvider.GetCPULoad();
                dataProvider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
