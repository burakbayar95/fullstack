using System;

namespace recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islem = new Islemler();
            Console.WriteLine(islem.Expo(5, 3));


            string ifade = "Burak BAYAR";
            bool sonuc = ifade.CheckSpace();
            if (sonuc)
            {
                Console.WriteLine(ifade.BoslukSil());

            }

            int[] dizi = { 3, 7, 15, 4, 666, 55, 41 };
            dizi.dizisirala();

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int ust)
        {
            if (ust < 2)
            {
                return sayi;
            }
            return Expo(sayi, ust - 1) * sayi;
        }
    }



    public static class Extension //static olması nesnesi olmadan erişebilmemizi sağlar
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string BoslukSil(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);

        }

        public static string buyukharfyap(this string param)
        {
            return param.ToUpper();

        }

        public static int[] dizisirala(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

    }
}
