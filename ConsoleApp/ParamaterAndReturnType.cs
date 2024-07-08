using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ParamaterAndReturnType
    {
        public void EmptyReturnType()
        {
            Console.WriteLine("Method with empty return type");
        }
        public int MethodWithReturnType()
        {
            return 7;
        }

        public int MethodWithParamterAndReturnType(int a, int b)
        {
            Console.WriteLine( "c"+" "+a+b);
            return 7;
        }

        public void MethodWithParameter(int age,char gender,string name)
        {
            Console.WriteLine(age+"  "+gender+"  "+name);
        }
    }
}
