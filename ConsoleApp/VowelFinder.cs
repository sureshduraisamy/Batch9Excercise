using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VowelFinder
    {
        char input;
        public void Vowel()
        {
            Console.WriteLine("enter letter in small case");
            input = Convert.ToChar(Console.ReadLine());

            if (input=='a'|| input == 'e' || input == 'i' || input == 'o' || input == 'u' )
            {
                Console.WriteLine("enter input is a vowel");
            }
            else
            {
                Console.WriteLine("enter input not vowel");
            }
        }
    }
}
