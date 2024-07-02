using System;

namespace Typocasting
{
    class Casting
    {

        public int a = 50;
        public int b = 40;
       
        public void changing()
        {
            int c = a;
            a = b;
            b = c;
                     
                   
            Console.WriteLine("after changing b to a" +" "+ a);
            Console.WriteLine("after changing a to b" + " "+b);
        }
                
    }
}
