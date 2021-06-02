using System;

namespace datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.AddDays(2));

            // Datetime format
            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("ddd"));//sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//April

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021


            //math

            Console.WriteLine(Math.Abs(-25));// mutlak değer alır

            Console.WriteLine(Math.Ceiling(22.3));//23 => 22 den büyük en küçük tamsayı // her zaman yukarı
            Console.WriteLine(Math.Round(22.3)); // 22 => en yakını getirir 22,7 =>23 // hangisi yakınsa
            Console.WriteLine(Math.Floor(22.7)); // aşağı yuvarlar =>23 // her zaman aşağı

            Console.WriteLine(Math.Pow(2,3));// 2 üzeri 3
            



            
              



           



            




        }
    }
}
