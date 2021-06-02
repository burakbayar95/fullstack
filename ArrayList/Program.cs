using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list=new ArrayList();
            list.Add("Kedi");
            list.Add(99);
            list.Add(true);

            Console.WriteLine(list[1]);

            string[] renkler={"kırmızı","sari"};
            List<int> sayilar=new List<int>(){1,8,9,1,4,55};


            list.AddRange(renkler);
            list.AddRange(sayilar);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
