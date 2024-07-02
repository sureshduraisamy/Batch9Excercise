using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SwitchingValue
    {
        public int a = 90;
        public int b = 50;
        public int c;

       
        public void switchingValue()
        {
            Console.WriteLine("A="+a);
            Console.WriteLine("B="+ b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("after changing values");
            Console.WriteLine("A=" + a);
            Console.WriteLine("B=" + b);

        }
    }
}
