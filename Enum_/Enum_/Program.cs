using System;
using System.ComponentModel.Design;

namespace Enum_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Gunler.Carsambe);
            Console.WriteLine((int)Gunler.Pazaretesi);
           

            int sicaklik = 32;
            if (sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarı çıkmak için sıkıntı");
            }
           
        }
    }

    internal enum Gunler
    {
        Pazaretesi = 1,
        Salı,
        Carsambe,
        Persembe
    }

     enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25
    }
}