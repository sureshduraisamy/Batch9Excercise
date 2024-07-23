using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
    
       public class ParentClass
        {
         public ParentClass()
        {
            Console.WriteLine("Constructor for parents class");
        }
            public virtual void M1()
            {
                Console.WriteLine("M1 is method in parentClass it is called using" +
                    "C class object and printed in console");
            }
        }

      public  class C : ParentClass
        {

        }
    public   class DerivedClass : ParentClass
        {
            public override void M1()
            {
           
              Console.WriteLine("Parent class M1 method overide by derived class" +
                    "M1 method and printed in console app");
            }
        }
    
}
