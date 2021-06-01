using System;

namespace array_method
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayi={23,12,45,5,88,77};
            foreach (var item in sayi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------Sıralı Dizi---------");
            Array.Sort(sayi);
            foreach (var item in sayi)
            {
                Console.WriteLine(item);
            }

            //clear => dizinin elamanını sıfırlıyor Array.Clear(dizi,2,2) => "dizi" dizisindeki 2.elemandan başla
            //ve 2 elamanı 0 la



            //-----------


            //Diziyi tersine çevirme
             Array.Reverse(sayi);
            foreach (var item in sayi)
            {
                Console.WriteLine(item);
            }

            //****

            

             Console.WriteLine(Array.IndexOf(sayi,12));// dizideki şu elaman kaçıncı indexte bulunuyor.

             Array.Resize<int>(ref sayi,9);// dizinin boyutunu 9 yaptı


        }
    }
}
