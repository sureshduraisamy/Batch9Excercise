using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ClassMarkTotal
    {
        public String name  = "manikandan";
        public int subject1 = 99;
        public int subject2 = 99;
        public  int subject3 = 99;
        decimal total;
        public void MarkCalculation()
        {
           total = subject3 + subject2 + subject1;
            Console.WriteLine(name);
           Console.WriteLine(total);
            PercenatgeOfMark();


        }

        public void PercenatgeOfMark()
        {
            decimal percentage = (total / 300 * 100);
            Console.WriteLine(percentage);




        }
    }
}
