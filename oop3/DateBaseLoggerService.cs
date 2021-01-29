using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    class DateBaseLoggerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Veritabanına Toplandı");
        }
    }
}
