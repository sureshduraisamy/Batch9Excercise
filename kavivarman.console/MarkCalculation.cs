using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarman.console
{
    class MarkCalculation
    {
        int count;
        public void Calculation()
        {
            count = Convert.ToInt32(Console.ReadLine());
            StudentMark[] students= new StudentMark[count];
            
            
            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine("enter student detail ");
                StudentMark sm = new StudentMark();
                sm.name = Console.ReadLine();
                sm.tamil = Convert.ToInt32(Console.ReadLine());
                sm.english = Convert.ToInt32(Console.ReadLine());
                sm.maths = Convert.ToInt32(Console.ReadLine());
                sm.science = Convert.ToInt32(Console.ReadLine());
                sm.social = Convert.ToInt32(Console.ReadLine());
               

                students[i] = sm;

            }
            for (int i = 0; i < count; i++) 
            {
                Console.WriteLine(students[i].name);
                Console.WriteLine(students[i].tamil);
                Console.WriteLine(students[i].english);
                Console.WriteLine(students[i].maths);
                Console.WriteLine(students[i].science);
                Console.WriteLine(students[i].social);

            }


        }
    }
}
