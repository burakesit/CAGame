using CAGame.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CAGame.Database
{
    public class FileLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veriler Dosyaya Kayıt Edildi. ");
        }
    }
}
