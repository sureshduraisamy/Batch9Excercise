using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Threading.Tasks;

namespace naveendevi.consol
{
    class Typecasting 
    { 

        public int a = 10;
        public int b = 20;
        public  int c;
        public void report()
        {
            c = a;
            a = b;
            b = c;
                
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }



    }
}
