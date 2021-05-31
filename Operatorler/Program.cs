using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
           int x= 3;
           int y=5;
           x++;
           y++;
           y=y+2;
           y+=2;
           Console.Write(y+"\n");

           int a=5;
           int b=5;
           int c=5;
           if(a==b && c==5)
           {
               Console.Write("Selam \n");
           }

             if(a==b || c==4)
           {
               Console.Write("Selam Kanka");
           }

           // % mod alma


        }
    }
}
