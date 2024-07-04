using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class BiggestNumber
    {


        public void Biggest()
        {
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            int secondvalue = Convert.ToInt32(Console.ReadLine());


            if (firstvalue > secondvalue)
            {
                Console.WriteLine("Biggest Number is ");
                Console.WriteLine(firstvalue);

            }

            else
            {
                Console.WriteLine("Biggest Number is ");
                Console.WriteLine(secondvalue);


            }

        }
            
        





        



        




    }
}
