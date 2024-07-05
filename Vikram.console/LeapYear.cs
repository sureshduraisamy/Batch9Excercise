using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class LeapYear
    {
        public void year()
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0) 
            {
                Console.WriteLine("Enter the Leap year ");

            }
            else
            {
                Console.WriteLine("Enter the Not Leap year");

            }
        }


            
            
            


            
            

            
            
        
    }
}
