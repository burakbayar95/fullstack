using System;

namespace for_break
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Sayi Giriniz: ");
          //  int sayi = int.Parse(Console.ReadLine());
            int teksayilartoplami=0;
           int ciftsayilartoplami=0;


/*

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);

                }

            }
*/
            for (int i = 0; i <= 1000; i++)
            {
                 if (i % 2 == 1)
                {
                teksayilartoplami+=i; //teksayilartoplami=i+teksayilartoplami;

                }

                if (i%2==0)
                {
                    ciftsayilartoplami+=i;//ciftsayilartoplami=i+ciftsayilartoplami;

                }

                
            }

            int toplam =teksayilartoplami+ciftsayilartoplami;
            Console.WriteLine("Tek sayılar toplamı= "+teksayilartoplami);
             Console.WriteLine("Çift sayılar toplamı= "+ciftsayilartoplami);
            Console.WriteLine("Toplam= "+toplam);
            
            // break = loop dan çıkmak
            // continue = sadece orayı atlayıp devam eder
/*
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
    
*/

  for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

    }
}
