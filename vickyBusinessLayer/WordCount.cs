using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vickyBusinessLayer
{
  public  class WordCount
  {
        string A = "I am Vicky";
        public void count()
        {
            string[] result = A.Split(' ');
            Console.WriteLine(result.Length);
        }
  }
    public class counting
    {
        string A = "I am Vicky";
        int count;
        public void countword()
        {
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count + 1);
        }
    }

    
}
