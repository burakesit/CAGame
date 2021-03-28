using CAGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Database
{
    public class DatabaseLogger : ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("Veriler Veritabınına Kayıt Edildi.");
        }
    }
}
