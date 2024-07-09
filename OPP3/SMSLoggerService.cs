using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP3
{
    public class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS yollandı");
        }
    }
}
