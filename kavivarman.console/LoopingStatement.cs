using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarman.console
{
    class ForLooping
    {
        public ForLooping()
        {
            for (int k = 1; k <= 50; k++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
            }
        }
        public ForLooping(int k)
        {
            for (k = 50; k >= 1; k--)
            {
                if (k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
            }
        }

      



        
        


    }
}
