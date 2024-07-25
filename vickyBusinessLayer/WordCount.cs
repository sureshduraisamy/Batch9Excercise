using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vickyBusinessLayer
{
class Wordcount
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence to count words:");
            string input = Console.ReadLine();

            // Call the function to count words
            int wordCount = CountWords(input);

            Console.WriteLine($"Word count: {wordCount}");
        }

        static int CountWords(string input)
        {
            // Split the input string by spaces
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the number of words
            return words.Length;
        }
    }

}

