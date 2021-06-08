using System;
using System.Collections;
using System.Linq;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();


            Console.Write("Lütfen sayi giriniz: ");
            for (int i = 1; i <= 7; i++)
            {
                int number;
                number = Convert.ToInt16(Console.ReadLine());

                if (number.GetType() == typeof(int))
                {
                    numbers.Add(number);
                }
            }
            var distinctArraylist = numbers.Cast<int>().Distinct().ToArray();

            Array.Sort((Array)distinctArraylist);
            Console.WriteLine("En küçük 3 sayı: ");
            Console.WriteLine(distinctArraylist[0] + " " + distinctArraylist[1] + " " + distinctArraylist[2]);

            int averagelow = (distinctArraylist[0] + distinctArraylist[1] + distinctArraylist[2]) / 3;
            Console.WriteLine("En küçük 3 sayı ortalaması: " + averagelow);

            Array.Reverse((Array)distinctArraylist);

            Console.WriteLine("En büyük 3 sayı: ");
            Console.WriteLine(distinctArraylist[0] + " " + distinctArraylist[1] + " " + distinctArraylist[2]);
            int averagebig = (distinctArraylist[0] + distinctArraylist[1] + distinctArraylist[2]) / 3;
            Console.WriteLine("En büyük 3 sayı ortalaması: " + averagebig);



        }
    }
}
