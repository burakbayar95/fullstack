using System;
using System.Collections.Generic;

namespace TO_DO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Member> members = new List<Member>();
            members.Add(new Member(1, "Burak"));
            members.Add(new Member(2, "Can"));
            members.Add(new Member(3, "Iknur"));
            members.Add(new Member(4, "Mert"));



            List<Card> cards = new List<Card>();
            cards.Add(new Card("Kart1", "işler", Size.S, members[0], Type.ToDo));
            cards.Add(new Card("Kart2", "işler2", Size.M, members[1], Type.InProgress));
            cards.Add(new Card("Kart2", "işler2", Size.M, members[2], Type.Done));


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
                        Listele();
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

        public void Listele(List<Card> cards ,List<Card> ToDo, List<Card> InProgress, List<Card> Done)
        {

           

            Console.WriteLine("");
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach (var item in ToDo)
            {

                Console.WriteLine("Başlık      :"+item.title);
                Console.WriteLine("İçerik      :"+item.content);
                Console.WriteLine("Atanan Kişi :"+item.member.Mem_name);
                Console.WriteLine("Büyüklük    :"+item.size);

            }
            

            Console.WriteLine("\n");
            Console.WriteLine("\n");


            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (var item in InProgress)
            {

                Console.WriteLine("Başlık      :" + item.title);
                Console.WriteLine("İçerik      :" + item.content);
                Console.WriteLine("Atanan Kişi :" + item.member.Mem_name);
                Console.WriteLine("Büyüklük    :" + item.size);

            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("Done Line");
            Console.WriteLine("************************");

            foreach (var item in Done)
            {

                Console.WriteLine("Başlık      :" + item.title);
                Console.WriteLine("İçerik      :" + item.content);
                Console.WriteLine("Atanan Kişi :" + item.member.Mem_name);
                Console.WriteLine("Büyüklük    :" + item.size);

            }




        }
    }
}
