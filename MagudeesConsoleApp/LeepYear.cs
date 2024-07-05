using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class LeepYear
    {
        public void leepyear()
        {
            Console.WriteLine("Enter The Year");
            int Year = Convert.ToInt32(Console.ReadLine());


            if (Year % 4 == 0)
            {
                Console.WriteLine("Leep Year");


            }
            else
            {
                Console.WriteLine("Not Leep Year");

            }














        }

    }
}
