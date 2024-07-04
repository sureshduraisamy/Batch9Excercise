using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class OddEven
    {
        int a;
        

        public void PrintOddEven()
        {
            a = Convert.ToInt32(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given Number is odd");
            }
          
        }
    }
}
