using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BiggestNumber
    {
        int a;
        int b;
         
        public void FindBigNo()
        {
            Console.WriteLine("enter the value for A variable");
          a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value for B variable");
            b =Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("Biggest Number of a="+a);
            }
            else{
                Console.WriteLine("Biggest Number of b=" + b);
            }
        }
    }
}
