using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class Iterate
    {
        string temp = "*";
        public void RowsandColums()
        {
            for (int j = 6; j >= 0; j--)
            {
                for (int i = j; i >= 1; i--)
                {
                    Console.Write(temp );
                }
                Console.WriteLine(temp);
            }
        }
        public void RowsandColumn1()
        {
            int k = 6;
            for(int a = 6; a >= 1; a--)
            {
               
                for(int b = a; b >= 1; b--)
                {
                    
                    Console.Write(k);

                }
                
                Console.WriteLine(k);

            }
        }
    } 
    
}
