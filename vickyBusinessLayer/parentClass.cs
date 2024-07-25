using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vickyBusinessLayer
{
  public  class parentClass
    {
        protected void m1()
        {
            Console.WriteLine("protected");
        }
        static parentClass()
        {
            Console.WriteLine("static");
        }
    }

}
