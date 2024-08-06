using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
   public class Exceptional
    {
        string A = "hi i am naveen";
        string b;
        public void words()
        {
            
            string[] data = A.Split(' ');
            for (int i = data.Length; i>0; i--)
            {
                b = b + data[i];
            }
            Console.WriteLine(b);
        }
    }

   
}
