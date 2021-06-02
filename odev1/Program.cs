using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.Soru //

            /*
            Console.WriteLine("Ne kadar sayi girmek istediğinizi yazınız: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            int [] dizi=new int [sayi];

            for(int i=0;i<sayi;i++)
            {
                Console.WriteLine(i+1 + ". sayiyi giriniz");
                dizi[i]=Convert.ToInt32(Console.ReadLine());

            }

            foreach (var item in dizi)
            {
                if(item%2==0)
                {
                    Console.WriteLine("Çift Sayı: "+item);
                }
                
            }
        

            */

            // 2. Soru //


            /*


            Console.WriteLine("Ne kadar sayi girmek istediğinizi yazınız: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem yapılacak sayi: ");
            int sayi2=Convert.ToInt32(Console.ReadLine());

            int [] dizi=new int [sayi];

            for(int i=0;i<sayi;i++)
            {
                Console.WriteLine(i+1 + ". sayiyi giriniz");
                dizi[i]=Convert.ToInt32(Console.ReadLine());

            }

            foreach (var item in dizi)
            {
                if(item==sayi2 || item%sayi2==0)
                {
                    Console.WriteLine("Sonuc: "+item);
                }
                
            }

            */

            // 3. Soru //



            /*

            Console.WriteLine("Ne kadar kelime girmek istediğinizi yazınız:");
            int sayi=Convert.ToInt32(Console.ReadLine());

            string [] dizi=new string [sayi];

            for(int i=0;i<sayi;i++)
            {
                Console.WriteLine(i+1 + ". kelimeyi giriniz");
                dizi[i]=(Console.ReadLine());

            }

            Array.Reverse(dizi);
            foreach (var item in dizi)
            {

                Console.WriteLine(item);
                
            }

            */


            // 4. Soru //

            Console.WriteLine("Bir kelime yazınız:");

            string yazi=Console.ReadLine();

            string[] dizi=yazi.Split(" ");

            Console.WriteLine("Kelime Sayisi= "+dizi.Length);

           int f=yazi.Length;

           int harfsayisi=f-(dizi.Length-1);

            
            Console.WriteLine("Harf Sayisi= "+harfsayisi);





            














        }
    }
}
