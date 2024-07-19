using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
   public class VowelsCount
    { 
        public void Vowels()
        {
            string a = "I am Rohit";
            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;
            for (int i = 0; i < a. Length; i++){
                char ch = char.ToLower(a[i]);
                if (ch == 'a')
                {
                    countA++;
                }
                else if(ch == 'e')
                {
                    countE++;
                }
                else if(ch == 'i')
                {
                    countI++;
                }
                else if(ch == 'o')
                {
                    countO++;
                }
                else if(ch == 'u')
                {
                    countU++;
                }

            }
            Console.WriteLine("count of a:" + countA);
            Console.WriteLine("count of e:" + countE);
            Console.WriteLine("count of i:" + countI);
            Console.WriteLine("count of o:" + countO);
            Console.WriteLine("count of u:" + countU);

                    


        }
    }
    

    
}
