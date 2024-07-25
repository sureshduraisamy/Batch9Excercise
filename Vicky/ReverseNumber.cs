using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicky
{
   public class ReverseNumber
    {
        public void numbers()
        {
            int a = 45678;
            while (a > 0)
                
            {
                int last = a % 10;
                a = a / 10;
                Console.WriteLine(last);

            }

        }
    }
}
