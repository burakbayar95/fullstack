using System;

namespace dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "kuş" };
            int[] dizi;
            dizi = new int[5];

            renkler[0] = "mavi";

            //-----
            Console.WriteLine("Dizinin eleman sayisini giriniz: ");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayi = new int[diziuzunlugu];
            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}.sayiyi giriniz", i + 1);
                sayi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayi)
            {
                toplam += item;
            }
            Console.WriteLine("Ortalama: "+ toplam/diziuzunlugu);


        }
    }
}
