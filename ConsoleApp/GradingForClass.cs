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
            else if (a>=80 && a<=89){
                Console.WriteLine("B");
            }
            else if (a >= 70 && a <= 79)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60 && a <= 69)
            {
                Console.WriteLine("D");
            }
            else if (a >= 50 && a <= 59)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
