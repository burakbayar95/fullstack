using System;

namespace Nesne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Calisan calisan1 = new Calisan();
            Calisan calisan2 = new Calisan("Can", 20);
            calisan1.Ad = "Burak";

            calisan1.CalisanBilgileri();
            calisan2.CalisanBilgileri();
        }
    }

    internal class Calisan
    {
        public string Ad;
        public int No;

        public Calisan(string ad, int no)
        {
            this.Ad = ad;
            this.No = no;
        }

        public Calisan()
        {
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adi {0}", Ad);
        }
    }
}