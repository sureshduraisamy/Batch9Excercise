using System;

namespace kavivarmanBusinesslayer
{
    public class oops
    {
        public int a = 10;
        public int b = 20;
        public void M1()
        {
            int c = a + b;      

        }
    }
 public class A : oops
    {
        public void M2()
        {
            Console.WriteLine(a + b);
            M1();

        }
    }
}
