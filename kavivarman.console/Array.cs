using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarman.console
{
    class Array
    {
        int[] values = new int[5];
        public Array()
        {
            for(int k = 1; k < 5; k++)
            {
                values[k] = Convert.ToInt32(Console.ReadLine());
            }
            for(int k = 1; k < 5; k++)
            {
                Console.WriteLine(values[k]);
            }
            int temp = 0;
                for (int k = 1; k < 5; k++)
            {
                temp = temp + values[k];
            }
            Console.WriteLine(temp);
        }
    }
}
