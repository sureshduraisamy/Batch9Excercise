using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ConsoleApp
{
    class biggernumber
    {

        public void BiggestNumb()
        {

            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());

            if(firstValue > secondValue)
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

        internal void number()
        {
            throw new NotImplementedException();
        }
    }
}
