using System;
using System.Collections.Generic;



namespace Vowelprogram
{
    public class Separatevowelcount
    {
        public void Finding()
        {
            Console.WriteLine("enter the sentance");
            string Sentance = Console.ReadLine();
            Sentance.ToLower();
            Console.WriteLine("enter the alphabet to been counted");
            string vowel = Console.ReadLine();
            int Total = 0;
            for (int i = 0; i < vowel.Length; i++)
            {
                Total = 0;
                for (int j = 0; j < Sentance.Length; j++)
                {
                    if (Sentance[j] == vowel[i])
                    {
                        Total++;
                    }
                }
                Console.WriteLine(vowel[i] + "=" + Total);


            }
        }
    }
}

