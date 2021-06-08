using System;

namespace Nesne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calisan calisan1 = new Calisan();
            calisan1.ad = "Burak";


            calisan1.CalisanBilgileri();


       

        }
    }

    class Calisan
    {
        public string ad;
        public int no;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adi {0}", ad);
        }

    }
}
