using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class Iterate
    {
        string temp = "*";
        public void RowsandColumns ()
        {
            for(int i = 6; i >= 0; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(temp);
                }
                Console.WriteLine(temp);
            }
        }
        
        public void RowsandColumns1()
        {
            int v= 4;
            for (int i = 4; i >= 0; i--)
            {
                for(int j = i; j >= 1; j--)
                {
                    Console.Write(v);
                }
                Console.WriteLine(v);

            }
        }
    }
}
