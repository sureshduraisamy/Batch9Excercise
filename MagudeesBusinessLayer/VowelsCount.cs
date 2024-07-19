using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesBusinessLayer
{
    class VowelsCount
    {





        public void count()
        {
            string s = "i am rohit";
            string b = "aeiou";
            int count = 0;

            for (int i = 0; i < b.Length; i++)
            {
             
                for (int k = 0; k < s.Length; k++)
                {
                    if (s[k] == b[i])
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

