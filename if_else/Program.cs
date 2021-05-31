using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
           int time=DateTime.Now.Hour;
         // int time =19;
         /*
            Console.WriteLine("Saat: "+time); 

            if(time>=9 && time<=18)
            {
               Console.WriteLine("Mesaidesin moruk"); 
            }
            else if(time>18 || time<9)
            {
                Console.WriteLine("You are free !.. Go go go");
            }

            */

            /*
            string message=time<18 && time>9 ? "Mesaidesin" : "Takılmaca";
            Console.WriteLine(message);

            */

            string message=time<18 && time>9 ? "Mesaidesin" : time>22 ? "Uyku Vakti": "Normal Takıl";

           
        }
    }
}
