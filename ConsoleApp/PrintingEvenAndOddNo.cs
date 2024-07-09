using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PrintingEvenAndOddNo
    {
        //default constructor
        public PrintingEvenAndOddNo()
        {
            for (int i = 1; i <= 50; i++) 
            {
                if (i%2==0)
                {
                    Console.WriteLine(i+" "+"is even Number");
                }
            }
        }

        //parametrized Constructor
        public PrintingEvenAndOddNo(int i)
        {
            for ( ; i >= 1; i--)
            {
                if (i%2 != 0)
                {
                    Console.WriteLine(i + " " + "is odd Number");
                }
            }
        }
    }
}
