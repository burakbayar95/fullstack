using System;

namespace while_
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;


            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama " + toplam / sayi);

            */

            /*
            char character = 'a';
            while (character<'z')
            {
               Console.Write(character);
               character++;
            }

           */
           string [] arabalar= {"bmw","fiat","toyota"};

           foreach (var araba in arabalar)
           {

               Console.WriteLine(araba);

               
           }


        }
    }
}
