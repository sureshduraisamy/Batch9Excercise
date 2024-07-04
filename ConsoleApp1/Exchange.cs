using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exchange
    {
        int a = 50;
        int b = 70;
        public void report()
        {
          
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
        
    }
}
