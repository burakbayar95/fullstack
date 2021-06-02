using System;

namespace string_
{
    class Program
    {
        static void Main(string[] args)
        {

            string degisken="Burak BAYAR";
            string degisken2="Burak BAYAR GG";

            Console.WriteLine(degisken.Length);
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            Console.WriteLine(String.Concat(degisken,"Ordinaryus"));// Concat => Birleştirme

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1 karşılaştırma

            Console.WriteLine(degisken.EndsWith("BAYAR")); //değişken verdiğimiz eğer ie bitiyor mu
            Console.WriteLine(degisken.IndexOf("B"));//ilk bulduğu yerin indexini verecek
            Console.WriteLine(degisken.Insert(0,"Merhaba"));// 0 ıncı indexten sonra yazıyı ekledi
            Console.WriteLine(degisken.LastIndexOf("B"));//Son indexi getirir
            Console.WriteLine(degisken+degisken2.PadLeft(30));// değişkenin sonuna 30 a tamamlayana kadar boşluk ekler
            Console.WriteLine(degisken.Remove(10));//10 nuncu indexten başlayıp sonrasını siliyor. 10 dan öncesini getirir
            Console.WriteLine(degisken.Remove(5,3));//5.karakterden başlayarak 3 karakter sil
            Console.WriteLine(degisken.Replace("Burak","BURAK"));//ilki ikinci ile değiştir *******
            Console.WriteLine(degisken.Split(" ")); // boşluğa göre kesip diziye atayacak
            Console.WriteLine(degisken.Substring(4,6));// 4den başla 6 ya kadar getir
            



            



            




        }
    }
}
