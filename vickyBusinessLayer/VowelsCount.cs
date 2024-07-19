using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vickyBusinessLayer
{
   public class VowelsCount
    {
        public void print()
        {
            string a = "i am rohit";
            string vowel = "a,e,i,o,u";
            int count = 0;
            
            for ( int i = 0; i < vowel.Length; i++)
            {
                for (int h = 0; h < a.Length; h++)
                {
                    if (a[h] == vowel[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(vowel[i] + " " + count);
                count = 0;
            }


          

         }
    }
}
