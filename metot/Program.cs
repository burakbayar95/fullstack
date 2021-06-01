using System;

namespace metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a=5;
            int b=10;
           int sonuc=(topla(a,b));

            Metotlar ornek= new Metotlar();
            ornek.ekranayazdir(sonuc.ToString());




        }
        static int topla(int deger1,int deger2)
        {
            return deger1+deger2;
        }
    }

    class Metotlar
    {
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
    }
}
