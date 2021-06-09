using System;
using System.Collections.Generic;

namespace To_Do
{
    class Program
    {
       
        static void Main(string[] args) 
        {


            AnaEkran();
            static void AnaEkran()
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
                Console.WriteLine("*******************************************");
               Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine(" (2) Board'a Kart Eklemek");
                Console.WriteLine(" (3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");

                int chose = Convert.ToInt16(Console.ReadLine());

                switch (chose)

                {
                    case 1:
                        
                        AnaEkran();

                        break;

                    case 2:
                       
                        AnaEkran();
                        break;

                    case 3:
                        
                        AnaEkran();
                        break;

                    case 4:
                        
                        AnaEkran();
                        break;


                    default: Console.WriteLine("Geçersiz Sayı"); break;
                }
            }

            
        }
      

        public static void Listele()
        {



            Console.WriteLine("");
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            Console.WriteLine("Başlık      :");
            Console.WriteLine("İçerik      :");
            Console.WriteLine("Atanan Kişi :");
            Console.WriteLine("Büyüklük    :");

            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            Console.WriteLine("Başlık      :");
            Console.WriteLine("İçerik      :");
            Console.WriteLine("Atanan Kişi :");
            Console.WriteLine("Büyüklük    :");

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("Done Line");
            Console.WriteLine("************************");




        }
    }
}
