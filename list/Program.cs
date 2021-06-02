using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            List<int> sayilistesi = new List<int>();

            sayilistesi.Add(23);
            sayilistesi.Add(2);
            sayilistesi.Add(92);
            sayilistesi.Add(55);

            List<string> renklistesi = new List<string>();

            renklistesi.Add("mavi");
            renklistesi.Add("yeşil");
            renklistesi.Add("kırmızzı");


            Console.WriteLine(renklistesi.Count);

            foreach (var sayi in sayilistesi)
            {

                Console.WriteLine(sayi);

            }

            sayilistesi.ForEach(sayi => Console.WriteLine(sayi));


            sayilistesi.Remove(4);// bu eleamı çıkar
            sayilistesi.RemoveAt(1); // 1.elemanı çıkar
            if (sayilistesi.Contains(10))// liste içerisinde arama yapar
            {
                Console.WriteLine("10 liste içerisinde var");

            }

            renklistesi.BinarySearch("mavi"); //eleman ile indexe erişme

            //---Diziyi Listeye Çevirme-----//

            string[] hayvanlar = { "Kedi", "Köpek" };
            List<string> hayvanListesi = new List<string>(hayvanlar);


            //liste içerisinde nesne tutmak

            List<Kullanicilar> kullanicilarlistesi=new List<Kullanicilar>();
            Kullanicilar kullanici1= new Kullanicilar();

            kullanici1.Isim="Burak";
            kullanici1.Soyisim="Bayar";
            kullanici1.Yas=26;

            Kullanicilar kullanici2= new Kullanicilar();

            kullanici2.Isim="Can";
            kullanici2.Soyisim="Bayar";
            kullanici2.Yas=22;

            kullanicilarlistesi.Add(kullanici1);
            kullanicilarlistesi.Add(new Kullanicilar()
            {
                Isim="Fatih",
                Soyisim="Terim",
                Yas=74
            });

            foreach (var kullanici in kullanicilarlistesi)
            {
                Console.WriteLine("Kullanici Adi: "+kullanici.Isim);
                Console.WriteLine("Kullanici Adi: "+kullanici.Soyisim);
            }





        }
    }
    public class Kullanicilar
    {
       private string isim;
      private  string soyisim;
      private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
