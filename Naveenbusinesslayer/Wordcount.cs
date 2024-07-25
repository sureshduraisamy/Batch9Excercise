using System;
using System.Collections.Generic;

namespace Wordcount
{
    public class Counting
    {
        string A = "hi i am naveen";
       
        public void wordcou()
        {
            string[] result = A.Split(' ');
            Console.WriteLine(result.Length);
            
        }

        
    }
    public class countingwoin
    {
        string A = "hi i am naveen";
        int count;
        public void countsword()
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count + 1);
        }

    }
        
}
