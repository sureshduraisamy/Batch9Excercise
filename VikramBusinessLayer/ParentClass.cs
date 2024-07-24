using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
  public  class ParentClass
    {
        protected void m1()
        {
            Console.WriteLine("protected");
        }
        static ParentClass()
        {
            Console.WriteLine("static");

        }
    }
}
