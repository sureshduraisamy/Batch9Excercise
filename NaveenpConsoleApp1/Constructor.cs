using System;


namespace Constructor
{
    class Constructorexe
    {
        public Constructorexe()
        {
            int a = 10;
            int b = 10;
            int c = a+b;
            Console.WriteLine(c);
        }
        public Constructorexe(int a,int b)
        {
            int c = a + b;

            Console.WriteLine(c);
        }
        public Constructorexe(int a)
        {
            if (a > 20)
            {
                Console.WriteLine("a is greater than 20 ");
            }
            else { Console.WriteLine("a is less than 20"); }
        }
        public Constructorexe(int a,string name)
        {
            Console.WriteLine("my age is" + " " + a + " " + "my name is" + " " + name);
        }
    }
}
