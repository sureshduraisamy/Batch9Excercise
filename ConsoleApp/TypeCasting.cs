using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TypeCasting
    {
       
       
       public void typeCastingImplicit()
        {
            char b = 'A';
            Console.WriteLine(b);
            int a=b;
            Console.WriteLine(a);
        }

        public void typeCastingExplicit()
        {
            int a = 65;
            Console.WriteLine(a);
            char b = Convert.ToChar(a);
            Console.WriteLine(b);

        }

    }
}
