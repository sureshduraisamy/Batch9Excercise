using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
  public  class WordReverse
    {
        string A = "Hi I am Giri";
        string B = "";
        public void Reverse()
        {
            string[] result = A.Split(' ');
            for(int i = result.Length; i > 0; i--)
            {
                B = B + result[i - 1] + " ";
            }
            Console.WriteLine(B);
        }
        
   }
    public class Reversing
    {
        string A = " I am Giri";
        string c;
        string d;
        string f;
        public void Word()
        {
            for(int i = A.Length - 1; i >= 0; i--)
            {
                c = c + A[i];
                if(A[i]==' ' || i == 0)
                {
                    for(int j = c.Length-1 ; j >= 0; j--)
                    {
                        d = d + c[j];
                    }
                    c = "";
                    f = d;
                }
            }
            Console.WriteLine(f);
        }
    }
}
