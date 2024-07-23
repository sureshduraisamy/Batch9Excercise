using System;
using System.Collections.Generic;



namespace Vowelprogram
{
    public class Separatevowelcount
    {
        public void Finding()
        {
            //Console.WriteLine("enter the sentance");
            //string Sentance = Console.ReadLine();
            //Sentance.ToLower();
            //Console.WriteLine("enter the alphabet to been counted");
            //string vowel = Console.ReadLine();
            //int Total = 0;
            //for (int i = 0; i < vowel.Length; i++)
            //{
            //    Total = 0;
            //    for (int j = 0; j < Sentance.Length; j++)
            //    {
            //        if (Sentance[j] == vowel[i])
            //        {
            //            Total++;
            //        }
            //    }
            //    Console.WriteLine(vowel[i] + "=" + Total);
            int input = 4;

            for (int i = input; i > 0; i--)
            {
                // Print spaces before the numbers to align them correctly
                for (int k = 0; k < input - i; k++)
                {
                    Console.Write(" ");
                }

                // Print numbers in descending order from 'i' down to 1
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine(); // Move to the next line after each row of numbers
            }





        }
    }
}     



