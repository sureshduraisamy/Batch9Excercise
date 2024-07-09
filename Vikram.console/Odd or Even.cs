using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class Odd_or_Even
    {
        public Odd_or_Even()
        {
            for (int odd = 50; odd >= 1; odd--)
            {
                
                if (odd % 2  != 0)
                {
                    Console.WriteLine("odd:"+odd);
                } 
            }
            for(int even = 1; even <= 50; even++)
            {
                
                if(even % 2 == 0)
                {
                    Console.WriteLine("even:" + even);
                }
                    
            }
            
            

        }
    }
}
