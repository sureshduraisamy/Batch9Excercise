using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Odd_Or_Even
    {
        int Value1;

        public void findvalue()
        {
            Console.WriteLine("Enter the Value1");
            Value1 = Convert.ToInt32(Console.ReadLine());
         

        }
        public void Value()
        {
            if (Value1 % 2 == 0)
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
