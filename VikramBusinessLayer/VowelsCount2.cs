using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
   public  class VowelsCount2
    {
        public void Vowels()
        {
            Console.WriteLine("Enter Your String:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter Your count character:");
            string b = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                    {
                        count++;
                    }
                
                }
                Console.WriteLine(b[i] + " " + count);
                count = 0;
            }

        }

    }
}
