using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
  public  class Parent
    {
        protected void M1()
        {
            Console.WriteLine("protected");
        }
        static Parent()
        {
            Console.Write("Static");
        }
    }
}
