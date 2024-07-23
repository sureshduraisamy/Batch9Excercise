using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TwoDimensionalArray
    {
        int[,] var = { {1,2,3 }, {3,6,9} };
        public void Display()
        {
            int j = 0;
            for (int i=0;i<2;i++)
            {
                for (j=0 ;j<3;j++)
                {
                    Console.WriteLine(var[i, j]);
                  
                }
                
            }
            
        }
    }
}
