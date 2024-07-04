using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class OddorEvenNumber
    {
        public void Odd_Or_Even()
        {
            Console.WriteLine("Enter The Number");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine("The Given Number is Even");


            }
            else
            {
                Console.WriteLine("The Given Number is Odd");

            }
             




        }




    }
}
