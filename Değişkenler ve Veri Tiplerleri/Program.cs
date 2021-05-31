using System;

namespace Değişkenler_ve_Veri_Tiplerleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Console.WriteLine("");
            String degisken = " ";
            byte b=5;         // 1 byte
            sbyte c = 5;     // 1 byte
            short s=5;      // 2 byte
            ushort =5;     // 2 byte

            Int16 i16=2;        //2 byte
            int i=2;            // 2 byte
            Int32 i32=2;        //4 byte
            Int64 i64= 2;       //8 byte
            uint ui=2;          //4 byte
            long l=2;            // 8 byte
            float f=5;           // 4 byte = reel sayılar
            double d=5;          // 8byte
            decimal de=4;        //16byte

            char ch='s'; // 2byte
            string str= "deneme"; //sınırsız
            bool b1=true;
            */

            DateTime dt= DateTime.Now;
            Console.WriteLine(dt);
            object o1="x";
            object o2=4;

            string str1=string.Empty;
            str1="Burak";

            string ad ="burak";
            string soyad="bayar";

            string isim= ad+ " " + soyad;
            string time = DateTime.Now.ToString("dd.MM.yyyy");
            string hour= DateTime.Now.ToString("HH:mm");
            


        }
    }
}
