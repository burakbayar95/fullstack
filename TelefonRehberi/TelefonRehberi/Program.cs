using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AnaEkran();
            static void AnaEkran()
            {
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
                Console.WriteLine("(1) Yeni Numara Eklemek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncellemek");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                int chose = Convert.ToInt16(Console.ReadLine());

                switch (chose)

                {
                    case 1:
                        AddPerson();
                        AnaEkran();

                        break;

                    case 2:
                        DeletePerson();
                        AnaEkran();
                        break;

                    case 3:
                        UpdatePerson();
                        AnaEkran();
                        break;

                    case 4:
                        List();
                        AnaEkran();
                        break;

                    case 5:
                        SearchPerson();
                        AnaEkran();
                        break;

                    default: Console.WriteLine("Geçersiz Sayı"); break;
                }
            }
        }

        public static List<Person> persons = new List<Person>();
        public static int i = 0;

        public static void AddPerson()
        {
            Person person = new Person();
            Console.WriteLine("Lütfen İsim Giriniz:  ");
            person.Name = Console.ReadLine().ToLower();
            Console.WriteLine("Lütfen Soyisim Giriniz.");
            person.LastName = Console.ReadLine().ToLower();
            Console.WriteLine("Lütfen Numara Giriniz.");
            person.PhoneNumber = Console.ReadLine();

            persons.Add(person);

            Console.WriteLine(persons[i].Name + " Adli kişi eklendi");
            i++;
        }

        public static void DeletePerson()
        {
            Console.WriteLine("Silmek istediğiniz ismi giriniz:  ");
            string deleteName = Console.ReadLine().ToLower();

            for (int i = 0; i < persons.Count; i++)
            {
                if (deleteName == (persons[i].Name).ToString())
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(persons[i].Name + " adli kişi silindi");
                    Console.WriteLine("\n");

                    persons.RemoveAt(i);
                }
            }
            Console.WriteLine("Lütfen geçerli bir değer giriniz..");
        }

        public static void UpdatePerson()
        {
            Console.WriteLine("Güncellemek istediğiniz ismi giriniz:  ");
            string updateName = Console.ReadLine().ToLower();

            for (int i = 0; i < persons.Count; i++)
            {
                if (updateName == (persons[i].Name).ToString())
                {
                    Console.WriteLine("\n");

                    Console.WriteLine("Lütfen İsim Giriniz:  ");
                    persons[i].Name = Console.ReadLine().ToLower();
                    Console.WriteLine("Lütfen Soyisim Giriniz.");
                    persons[i].LastName = Console.ReadLine().ToLower();
                    Console.WriteLine("Lütfen Numara Giriniz.");
                    persons[i].PhoneNumber = Console.ReadLine().ToLower();

                    Console.WriteLine("Güncelleme Gerçekleşti...");
                }
            }
            Console.WriteLine("Lütfen geçerli bir değer giriniz..");
        }

        public static void List()
        {
            Console.WriteLine("Rehberdeki Kişiler");
            foreach (var item in persons)
            {
                Console.WriteLine(" " + item.Name + " " + item.LastName + " " + item.PhoneNumber);
            }
        }

        public static void SearchPerson()
        {
            Console.WriteLine("Arama istediğiniz ismi giriniz:  ");
            string searchName = Console.ReadLine().ToLower();

            for (int i = 0; i < persons.Count; i++)
            {
                if (searchName == (persons[i].Name).ToString())
                {
                    Console.WriteLine("Aradığınz kişinin bilgileri :" + persons[i].Name + " " + persons[i].LastName + " " + persons[i].PhoneNumber);
                    Console.WriteLine("\n");
                }

               

            }
            Console.WriteLine("Lütfen geçerli bir değer giriniz..");
        }
        
    }
}