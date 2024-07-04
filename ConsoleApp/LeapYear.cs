using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LeapYear
    {
        int a;
        public void PrintLeapYr()
        {
            a = Convert.ToInt32(Console.ReadLine());
           
            if (a%4==0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
