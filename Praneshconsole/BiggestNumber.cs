using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class BiggestNumber
    {
        int a;
        int b;

        public void biggest()
        {
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());


            if (firstValue > secondValue)
            {
                Console.WriteLine("Biggest number is");
                Console.WriteLine (firstValue);

            }
            else
            {
                Console.WriteLine("Biggest number is");
                Console.WriteLine (secondValue);

            }







        }


    }
}      




















