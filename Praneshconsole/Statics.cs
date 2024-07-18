using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class Statics
    {
        
        public Statics() 
        {
            Console.WriteLine("hai");
        
        }
        static Statics()

        {
            Console.WriteLine("hello");
        }
        public Statics( int a)
        {
          



            Console.WriteLine("parameter+ a ");
        }
    }
}
