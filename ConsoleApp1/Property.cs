using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kavi.console
{
    class property
    {

        public void method()
        {
            for (int row = 6; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("1");
                }

                Console.WriteLine();
            }
          
        }
    }





}

