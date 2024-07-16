using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Arithmetic
    {
       public int Age
        {
            get
            {   return 9;
            }
            set
            {
                Age = 21;
            }
    
        }
        
       public void multiplication()
        {
           
            Console.WriteLine(Age);
            Console.WriteLine("performing multiplication"+" "+5*10);

        }
    }
}
