using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarmanBusinesslayer
{
    public class A
    {
        protected void M1()
        {
            Console.WriteLine("protected");
        }
        static A()
        {
            Console.WriteLine("static");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("PUBLIC");
        }
        public void M2()
        {
            Console.WriteLine("CLASS B");
            M1();
        }
        public void M2(string A)
        {
            M1();
        }
        public String M2(int a)
        {
            return "10";
        }
    }
}
