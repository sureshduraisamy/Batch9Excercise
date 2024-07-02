using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class Exchange
    {
        int a = 50;
        int b = 90;
        int c;

        public void report()
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
   

        



    }
}
