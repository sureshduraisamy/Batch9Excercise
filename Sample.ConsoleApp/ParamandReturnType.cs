using System;

namespace Sample.ConsoleApp
{
    class ParamandReturnType
    {
        int a = 10;

        public void Addition()
        {
            int a = 10;
            Console.WriteLine("Hai");
        }


        public void Addition(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public string Addition(int age, 
            char gender,
            string name)
        {
            Console.ReadLine();

            return name;
        }

    }
}
