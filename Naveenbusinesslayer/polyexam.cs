using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyexecrise
{
    public class polyexam
    {
        protected void Mainfun()
        {
            Console.WriteLine("protected");
        }
        static polyexam()
        {
            Console.WriteLine("static");
        }
    }
    public class Nextstep : polyexam
    {
        public Nextstep()
        {
            Console.WriteLine("public");
        }
        public void Submain()
        {
            Console.WriteLine("class nextstep");
            Mainfun();
        }
        public void Submain(string a)
        {
            Mainfun();
        }
        public string Submain(int a)
        {
            return "10";
        }
    }
}
