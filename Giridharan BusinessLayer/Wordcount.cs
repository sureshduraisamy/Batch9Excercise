using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
   public class WordCount
    {
        string A = "I am Giri";
        public void Count()
        {
            string[] result = A.Split(' ');
            Console.WriteLine(result.Length);
        }
         
    }
    public class Counting
    {
        string A = "Hi I am giri";
        int count;
        public void Countsword()
        {
            for(int i = 0; i < A.Length; i++)
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
