using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class StudentCalculation
    {
        int count;
        public void Calculation()
        {
            count = Convert.ToInt32(Console.ReadLine());
            StudentMark[] students = new StudentMark[count];
            for(int i = 0; i < count; i++)
            {
                StudentMark sm = new StudentMark();
                sm.Name = Console.ReadLine();
                sm.Tamil = Convert.ToInt32(Console.ReadLine());
                sm.English = Convert.ToInt32(Console.ReadLine());
                sm.Maths = Convert.ToInt32(Console.ReadLine());
                sm.science = Convert.ToInt32(Console.ReadLine());
                sm.socialscience = Convert.ToInt32(Console.ReadLine());

               students[i] = sm;


            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(students[i].Name);
                Console.WriteLine(students[i].Tamil);
                Console.WriteLine(students[i].English);
                Console.WriteLine(students[i].Maths );
                Console.WriteLine(students[i].science);
                Console.WriteLine(students[i].socialscience);

            }
        }
    }
}
