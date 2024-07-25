using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarmanBusinesslayer
{
   
   public class NumberReverse
    {
        int A = 1285;
        public void numbers()
        {
            while (A > 0)
            {
                int last = A % 10;
                A = A / 10;
                Console.Write(last);
            }
        }
    }
}
