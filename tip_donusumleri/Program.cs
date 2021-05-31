using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 4;
            byte y = (byte)x; //tip dönüşümü yaptık
            Console.WriteLine("y: " + y);

            //ToString

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);


            // System.Convert

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + Toplam);


            //Parse string ifadeleri dönüştürme için kullanılır.

            string meti1="10";
            string metin2="10.25";
            int rakam1;
            double double1;
            double1=Double.Parse(metin2);

            rakam1=Int32.Parse(meti1);
             Console.WriteLine("Rakam1: " + rakam1);
             Console.WriteLine("Rakam2: " + double1);




        }
    }
}
