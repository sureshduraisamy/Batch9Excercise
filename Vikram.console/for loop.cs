using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class for_loop
    {
        public void CalulateSum()
        {
            int n = 5, sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of first {0}natural number={1}", n, sum);
        }

        
    }
}
