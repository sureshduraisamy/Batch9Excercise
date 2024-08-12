using System;
using System.Linq;

namespace Kavi.console
{
    class Vowelsopt
    {
        public  void Main()
        {
            {
                Console.WriteLine("Enter the statement");
                string input = Console.ReadLine();
                int[] alphabetCounts = new int[26];

                for(int i=0;i<input.Length;i++)
                {
                    char c = char.ToLower(input[i]);
                    if (c >= 'a' && c <= 'z')
                    {
                        int index = c - 'a';
                        alphabetCounts[index]++;
                    }
                }
                for(int i = 0; i < 26; i++)
                {
                    char letter = (char)('a' + i);
                    int count = alphabetCounts[i];
                    if (count > 0)
                    {
                        Console.WriteLine($"Letter:{letter},Count:{count}");
                    }
                }
            }


        }

        
    }
}
