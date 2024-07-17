using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicky
{
    class Loopstatement
    {

        string temp = "*";
        public Loopstatement()
        {
            for (int j = 6; j >= 1; j--)
            {
                for (int i =j; i > 0; i--)
                {
                    Console.Write(temp);
                    
                }


                Console.WriteLine();
            }
        }
    }
}
