using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MultiLevelInheritance
    {
        class ParentClass
        {
            public virtual void M1()
            {
                Console.WriteLine("M1 is method in parentClass it is called using" +
                    "C class object and printed in console");
            }
        }

        class C : ParentClass
        {

        }
        class DerivedClass : ParentClass
        {
            public override void M1()
            {
              Console.WriteLine("Parent class M1 method overide by derived class" +
                    "M1 method and printed in console app");
            }
        }
    }
}
