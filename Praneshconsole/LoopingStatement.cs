using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class LoopingStatement
    {
        public LoopingStatement()
        {
            int temp = 1;
            for (int i=1; i>=10; i++)
            {
                temp = temp * i;
            }


            Console.WriteLine(temp);
        
        }




    }
}
