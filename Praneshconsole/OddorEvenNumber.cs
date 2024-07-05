using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class OddorEvenNumber
    {
        int value1;



        public void OdderEven()
        {
            Console.WriteLine("Enter the value");
            value1 = Convert.ToInt32(Console.ReadLine());




            if (value1 % 2 == 0)
            {
                Console.WriteLine("Enter number is an Even number");

            }
            else
            {
                Console.WriteLine("Enter number is an Odd number");
            }

        }






    }
}
