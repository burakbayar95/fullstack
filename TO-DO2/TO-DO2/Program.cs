using System;
using System.Collections.Generic;
using System.Linq;

namespace TO_DO2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //List<Member> members = new List<Member>();
            //members.Add(new Member(1, "Burak"));
            //members.Add(new Member(2, "Can"));
            //members.Add(new Member(3, "Iknur"));
            //members.Add(new Member(4, "Mert"));

            //List<Card> cards = new List<Card>();
            //cards.Add(new Card("Kart1", "işler", Size.S, members[0], Type.ToDo));
            //cards.Add(new Card("Kart2", "işler2", Size.M, members[1], Type.InProgress));
            //cards.Add(new Card("Kart2", "işler2", Size.M, members[2], Type.Done));

            AnaEkran();
            static void AnaEkran()
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine(" (2) Board'a Kart Eklemek");
                Console.WriteLine(" (3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Card card = new Card();

                int chose = Convert.ToInt16(Console.ReadLine());

                switch (chose)

                {
                    case 1:
                        Listele();
                        AnaEkran();

                        break;

                    case 2:
                        KartEkle();
                        AnaEkran();
                        break;

                    case 3:
                          KartSil();

                        //List<Card> cardss = new List<Card>();
                       // DeleteCard(cardss);
                        AnaEkran();
                        break;
                        
                    case 4:

                        AnaEkran();
                        break;

                    default: Console.WriteLine("Geçersiz Sayı"); break;
                }
            }
        }

        public static bool DeleteCard(List<Card> cards)

        {
            Console.Write("Öncellikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write(" Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();

            foreach (var item in cards)
            {
                if (item.title.Equals(baslik))
                {
                    cards.Remove(item);
                    Console.WriteLine("Kart Board'dan başarılı bir şekilde silinmiştir.");
                    return true;
                }
            }
            return false;
        }
        public static void KartSil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");

            string DeletedItem = Console.ReadLine().ToString();

            List<Card> cards = new List<Card>();
            

            foreach (var item in cards)
            {
                if (item.title.ToLower() == DeletedItem.ToLower())
                {
                    cards.Remove(item);
                    Console.WriteLine("Kart Board'dan başarılı bir şekilde silinmiştir.");
                }
            }

            //foreach (var item in BoardData.board.ToDo)
            //{
            //    //board.ToDo.Remove(item);

            //    if(item.title.ToLower()==DeletedItem.ToLower())

            //    {
            //        BoardData.board.ToDo.Remove(item);
            //    }

            //}
        }

        public static void KartEkle()
        {
            Card card = new Card();
            Member member = new Member();

            Board board = new Board();

            Console.WriteLine(" Başlık Giriniz                                  : ");
            card.title = Console.ReadLine();
            Console.WriteLine(" İçerik Giriniz                                  :");
            card.content = Console.ReadLine();
            Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            card.size = (Size)int.Parse(Console.ReadLine());
            Console.WriteLine(" Kişi Seçiniz                                    : ");
            int memberId = int.Parse(Console.ReadLine());
            if (MemberData.members.FirstOrDefault(x => x.Id == memberId) == null)
            {
                Console.WriteLine("Hatalı girişler yaptınız!");
            }
        }

        public static void Listele()
        {
            Console.WriteLine("");
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach (var item in BoardData.board.ToDo)
            {
                Console.WriteLine("Başlık      :" + item.title);
                Console.WriteLine("İçerik      :" + item.content);
                Console.WriteLine("Atanan Kişi :" + MemberData.members.FirstOrDefault(x => x.Id == item.memberid).Mem_name);
                Console.WriteLine("Büyüklük    :" + item.size);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (var item in BoardData.board.InProgress)
            {
                Console.WriteLine("Başlık      :" + item.title);
                Console.WriteLine("İçerik      :" + item.content);
                Console.WriteLine("Atanan Kişi :" + MemberData.members.FirstOrDefault(x => x.Id == item.memberid).Mem_name);
                Console.WriteLine("Büyüklük    :" + item.size);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("Done Line");
            Console.WriteLine("************************");

            foreach (var item in BoardData.board.Done)
            {
                Console.WriteLine("Başlık      :" + item.title);
                Console.WriteLine("İçerik      :" + item.content);
                Console.WriteLine("Atanan Kişi :" + MemberData.members.FirstOrDefault(x => x.Id == item.memberid).Mem_name);
                Console.WriteLine("Büyüklük    :" + item.size);
            }
        }
    }
}