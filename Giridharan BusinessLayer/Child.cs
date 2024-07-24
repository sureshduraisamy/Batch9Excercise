using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
   public class Child : Parent
    {
        public Child()
        {
            Console.Write("Public");
        }
        public void M2()
        {
            Console.WriteLine("Class Child");
            M1();
        }
        public void M2(string a)
        {
            M1();
        }
        public string M2(int a)
        {
            
            return "10" ;
        }
    }        
}
