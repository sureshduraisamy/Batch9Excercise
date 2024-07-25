using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
   public class Reversenumber
    {
        public void Numbers()
        {
            int a=54678;
            while (a > 0)
            {
                int last = a % 10;
                a = a / 10;
                Console.Write(last);
            }
            
        }
    }
}
