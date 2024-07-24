using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
   public class ChildClass:ParentClass
    {
        
        
            public ChildClass()
            {
                Console.WriteLine("public");
            }
            public void M2()
            {
                Console.WriteLine("ChildClass");
               m1();
            }
            public void M2(string a)
            {
                m1();            
            }
            public string M2(int a)
            {
                return "10";

            }
        
    }
}
