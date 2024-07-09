using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicky
{
    class EvenOrOdd
    {
        public EvenOrOdd() 
        {
        for (int even=1;even <50;even ++)
                if (even % 2 == 0) 
                {
                    Console.WriteLine("even:" + even);
                
                }

            for (int Odd = 50; Odd >= 1; Odd--) 
            {
                if (Odd % 2 != 0)

                    Console.WriteLine("Odd:" + Odd);
            }        
              
        
        
        }
    }
}
