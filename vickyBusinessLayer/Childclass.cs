using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vickyBusinessLayer
{
    public class Childclass:parentClass
   
    {
        public Childclass ()
        {
            Console.WriteLine("public");

        }
        public void m2()
        {
            Console.WriteLine("Childclass");
            m1();
        }
        public void m2(string a)
        {
            m1();
        }
        public string m2(int a)
        {
            return "10";
        }
    }
}
