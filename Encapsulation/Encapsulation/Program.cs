using System;

namespace Encapsulation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Isim = "Burak";
            ogr1.No = 645;
            ogr1.BilgiGetir();
            ogr1.NumaraDegistir();
            ogr1.BilgiGetir();
        }
    }

    internal class Ogrenci

    {
        private string isim;
        private int no;

        public string Isim { get => isim; set => isim = value; }

        public int No
        {
            get => no;
            set
            {
                if(value<1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir...");
                }

                else
                no = value;
            }
        }

        public Ogrenci(string isim, int no)
        {
            Isim = isim;
            No = no;
        }

        public Ogrenci()

        {
        }

        public void BilgiGetir()
        {
            Console.WriteLine("Ogrenci Adi:  {0}", this.Isim);
            Console.WriteLine("Ogrenci No:  {0}", this.No);
        }

        public void NumaraDegistir()
        {
            this.No = this.No + 1;
        }
    }
}