using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ArrayValues
    {
        int[] values = new int[5];

      public int[]  Array()
        {
            for (int i=0;i<5;i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i<5;i++)
            {
                Console.WriteLine(values[i]);
            }

            ReturnInData(values);
            return values;
        }
        
        public int[] ReturnInData(int [] v)
        {

            int temp = 1;
            for (int i = 0; i < 5; i++)
            {
                temp = temp * v[i];
            }
            Console.WriteLine(temp);

            return values;
        }


    }
}
