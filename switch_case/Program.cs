using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int month = DateTime.Now.Month;
            switch (month)
            {
                case 1:

                    Console.WriteLine("Ocak");
                    break;

                case 6:

                    Console.WriteLine("Haziran");
                    break;


                default:
                    Console.WriteLine("Yanlış Veri Girişi..");
                    break;
            }

            switch (month)
            {

                case 1:
                case 2:
                case 3:
                 Console.WriteLine("Kış Ayı");
                 break;

                
                default:
                break;
            }
        }
    }
}
