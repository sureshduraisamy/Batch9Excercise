using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leap_year
    {
        int year;

        public void Leap()
        {
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void visit()
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", year);
            }

        }
    }
}
