using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class GradingForClass
    {
        int a;

        public void Grading(){
            a = Convert.ToInt32(Console.ReadLine());
            if (a>=90 && a<=100)
            {
                Console.WriteLine("A");
            }
            }
    }
}
