using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicky
{
    class OddorEven
    {
        int value1;

        public void findvalue()
        {
            Console.WriteLine("Enter the value1");
            value1 = Convert.ToInt32(Console.ReadLine());


        }
        public void value()
        {
            if (value1 % 2 == 0)
            {
                Console.WriteLine("Entered number is an Even number");

            }
            else
            {
                Console.WriteLine("Entered number is an Odd number");
            }
              
        }
        
    }
}
