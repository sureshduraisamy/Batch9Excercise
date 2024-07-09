
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class Odd_OR_Even
    {
        public Odd_OR_Even()
        {
            for (int odd = 50; odd >= 1; odd--)
            {

                if (odd % 2 != 0)
                {
                    Console.WriteLine("odd:" + odd);
                }
                else
                {
                    Console.WriteLine("Even:" + odd);
                }


                
            }
        }
    }
}
