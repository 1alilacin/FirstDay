using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosya loglandı");
        }
    }
}
