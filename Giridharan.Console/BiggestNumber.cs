using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class BiggestNumber
    {
        public void BiggestNum()
        {
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            int secondvalue = Convert.ToInt32(Console.ReadLine());

            if (firstvalue > secondvalue)
            {
                Console.WriteLine("The Biggest number is:");
                Console.WriteLine(firstvalue);
            }
            else
            {
                Console.WriteLine("The Biggest Number is:");
                Console.WriteLine(secondvalue);
            }

        }
        public void Add_Or_Even()
        {
            Console.WriteLine("Enter The Number:");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value % 2 == 0)
            {
                Console.WriteLine("The Given Number is Even");
            }
            else
            {
                Console.WriteLine("The Given Number is Add");
            }
        }
        public void LeapYear()
        {
            Console.WriteLine("Enter Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0)
            {
                Console.WriteLine(year+" is a Leap Year");
            }
            else
            {
                Console.WriteLine(year+" is not a Leap Year");
            }
        }
    }
}
