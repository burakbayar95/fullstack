using System;

namespace Interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Smslogger sms = new Smslogger();
            sms.WriteLog();
        }
    }

    public interface Ilogger
    {
        void WriteLog();

    }

    public interface Databaselogger : Ilogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e  yazar");

        }

    }

    public class Smslogger :Ilogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya log yazar");

        }
    }
}
