using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class Array
    {
        int[] values = new int[10];
           public Array()
        {
            for (int i = 0; i < 10; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(values[9]);
            }
            int temp = 0;
            for (int i = 1; i < 10; i++)
            {
                temp = temp + values[i];
            }
            Console.WriteLine(temp);
           
            

        }
        
            
        
    }
}
