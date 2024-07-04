using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicky
{
    class Bignumber
    {
        int value1;
        int value2;

        public void large()
        {
            Console.WriteLine("Enter the value1");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value2");
            value2 = Convert.ToInt32(Console.ReadLine());

        }

        public void big()
        {
            if (value1 > value2)
            {
                Console.WriteLine("Value1 is bigger");
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine("Value2 is bigger");
                Console.WriteLine(value2);
            }
        }
    }
}
