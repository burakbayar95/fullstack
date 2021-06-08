using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümle giriniz");
            string word = Console.ReadLine();
            string vowels = "aeiou";


            ArrayList letters = new ArrayList();
            ArrayList Vowels = new ArrayList();
            ArrayList FindingVowels = new ArrayList();


            foreach (var item in word)
            {
                letters.Add(item);
            }

            foreach (var item in vowels)
            {
                Vowels.Add(item);
            }


            for (int i = 0; i < letters.Count; i++)
            {
                for (int j = 0; j < Vowels.Count; j++)
                {
                    if (letters[i].ToString() == Vowels[j].ToString())
                    {
                        FindingVowels.Add(letters[i]);
                    }
                }
            }


            var arrayFindingVowels = FindingVowels.Cast<char>().Distinct().ToArray();
            foreach (var item in arrayFindingVowels)
            {
                Console.WriteLine("Ünlü harfler " + item);
            }


        }
    }
}
