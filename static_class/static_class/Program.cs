using System;

namespace static_class
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı {0}: ", Calisan.Calisansayisi);
            Calisan cls1 = new Calisan("Burak");
            Console.WriteLine("Çalışan Sayısı {0}: ", Calisan.Calisansayisi);


            Console.WriteLine("Toplam= {0}", Islemler.Topla(20, 50));   

        }
    }

    internal class Calisan
    {
        private static int calisansayisi;

        public static int Calisansayisi { get => calisansayisi; } //sınıf bazında atanır

        private string Isim;

        static Calisan()
        {
            calisansayisi = 0;
        }

        public Calisan(string isim)
        {
            this.Isim = isim;

            calisansayisi++;
        }

        public Calisan()
        {
        }
    }

     static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}