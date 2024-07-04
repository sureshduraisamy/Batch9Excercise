using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaviyarasu__r
{
    class Biggestnumber
    {
        public void Ifcondition()
        {
            Console.WriteLine("enter a number");
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number");
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            if (firstvalue > secondvalue)
            {
                Console.WriteLine("the biggest number is" + firstvalue);

            }
            else
            {
                Console.WriteLine("the biggest number is" + secondvalue);
            }
        }

        public void Evenorodd()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }

        }
    } }
