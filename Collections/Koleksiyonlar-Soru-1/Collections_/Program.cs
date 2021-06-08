using System;
using System.Collections;

namespace Collections_
{
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList primenumber = new ArrayList();
            ArrayList nonprimenumber = new ArrayList();


            Console.WriteLine("Lütfen 20 adet sayi giriniz: ");
            for (int i = 1; i <= 4; i++)
            {
              
                int number;
                number = Convert.ToInt16(Console.ReadLine());

                int count = 0;
                
                if (number > 0 && number.GetType()==typeof(int))
                {
                    if(number==1)
                    {

                        Console.WriteLine("1 girmeyiniz.");
                        continue;

                    }
                    

                    for (int j = 2; j < number; j++)
                    {
                        
                        if (number % j == 0)
                        {
                            count ++;
                            break;
                           
                        }
                    }
                        if(count!=0)
                        {

                            nonprimenumber.Add(number);

                        }


                        else if(number!=1)
                        {
                            primenumber.Add(number);
                        }

   

                }

                else
                {
                    Console.WriteLine("Lütfen pozitif bir sayi giriniz...");
                }



            }
            primenumber.Sort();
            primenumber.Reverse();
            nonprimenumber.Sort();
            nonprimenumber.Reverse();
           
                 Console.Write("Asal Sayılar: ");
            foreach (var item in primenumber)
            {
                Console.Write(" "+item);
            }
            Console.Write("\n");

            Console.Write("Asal Olmayan Sayılar: ");
            foreach (var item in nonprimenumber)
            {
                Console.Write(" " + item);
            }
            Console.Write("\n");
            int countofprime = primenumber.Count;
            Console.WriteLine("Toplam "+countofprime+" adet asal sayi vardir.");

            int countofnonprime = nonprimenumber.Count;
            Console.WriteLine("Toplam " + countofnonprime + " adet asal olmayan sayi vardir.");











        }
    }

   
}
