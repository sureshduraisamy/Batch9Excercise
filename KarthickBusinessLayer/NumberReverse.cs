using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
  public  class NumberReverse
    {
        int var = 3214;

        public void IntVarReverse()
        {
            while (var>0)
            {
                int last = var % 10;
                var = var / 10;
                Console.Write(last);
            }
        }
    }
}
