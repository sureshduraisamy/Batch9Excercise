using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kavi.console
{
    class Vowelsopt
    {
        public  void Main()
        {
            int total = 0;
            String sentence = "I am Rohith";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence.Contains("a") || sentence.Contains("e") || sentence.Contains("i") || sentence.Contains("o") || sentence.Contains("u"))
                {
                    total++;
                }
            }
            Console.WriteLine("The total number of vowels is: {0}", total);

            Console.ReadLine();
        }
    }
}
