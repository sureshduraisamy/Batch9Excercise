using System;

namespace Operators
{
    class Operatorfun
    {
        public void arthematicopp(int a , int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            result = a - b;
            Console.WriteLine(result);
            result = a * b;
            Console.WriteLine(result);
            result = a / b;
            Console.WriteLine(result);

        }
        public void conditonopp(int a, int b)
        {
            bool function = a > b;
            Console.WriteLine(function);
            function = a < b;
            Console.WriteLine(function);
            function = a == b;
            Console.WriteLine(function);



        }
        public void Logicalopp(int a, int b)
        {
            bool func = a > b && a < b;
            Console.WriteLine(func);
            func = a > b || a < b;
            Console.WriteLine(func);
        }
        public void unaryopp(int a)
        {
            Console.WriteLine(a);
            Console.WriteLine(a++);
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(a--);
            Console.WriteLine(a);
            Console.WriteLine(--a);
        }
    }
}
