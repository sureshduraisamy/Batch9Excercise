using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class BiggerNumber
    {
        public void BiggestNum()
        {
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());

            if (firstValue > secondValue)
            {
                Console.WriteLine("The Biggest Number is");
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine("The Biggest Number is");
                Console.WriteLine(secondValue);

            }

        }
    }


}




