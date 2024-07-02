using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class TypeCasting
    {
     public   int a= 50;
    public    int b = 40;
     public   int c;
      public void report()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
                c = a;
                a = b;
                b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
             

    }

}
