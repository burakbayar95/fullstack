using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "99";
            bool sonuc = int.TryParse(sayi, out int outsayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outsayi);
            }
            else Console.WriteLine("Başarısız..");

            Metotlar deneme = new Metotlar();
             deneme.Topla(2,3,out int Toplamsonuc);
             Console.WriteLine(Toplamsonuc);


             int ifade=9999;
             int ifade2=555;
             deneme.ekranayazdir(ifade.ToString());
              deneme.ekranayazdir(ifade.ToString(),ifade2.ToString());







        }

        
    }


    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }


        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }


          public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }

         public void ekranayazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }



}