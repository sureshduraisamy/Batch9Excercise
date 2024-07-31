using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordreverse
{
    public class Reversing
    {
        string A = "hi i am naveen";
        string b = "";
        public void wordcou()
        {
            string[] result = A.Split(' ');
            for (int i = result.Length; i > 0; i--)
            {
                b = b + result[i - 1] + " ";
            }
            Console.WriteLine(b);
        }
    }
    public class Reversingwosplit
    {
        string  A = "hi i am naveen";
        string c;
        string d;
        string s;
        public void words()
        {
            for(int i = A.Length-1; i >= 0; i--)
            {
                c = c + A[i ];
                if (A[i] == ' ' || i == 0)
                {
                    for (int j = c.Length-1; j >= 0; j--)
                    {
                        d = d + c[j];
                    }
                    
                    c = " ";
                    s = d;

                }
                
            }


            Console.WriteLine(s);
        }
    }
}
