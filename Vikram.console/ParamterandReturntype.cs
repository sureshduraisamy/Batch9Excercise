using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class ParamterandReturntype
    {
        string name ;
        int age ;
        char gender;
        public void Addition()
        {
            string name = "vikram";
            int age = 22;
            char gender = 'M';
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);

        }
        public void Details(int age, char gender, string name)
        {
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(name);


        }
        public void EmptyReturnTyoe()
        {
            Console.WriteLine();
        }
        public int MethodwithReturnType()
        {
            return 8;

        } 
        

    }
}
