using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class Marklist
    {
        int count;
       




        public void Calculation ()
        {
            Console.WriteLine("no.of.students:");
            count = Convert.ToInt32(Console.ReadLine());
            StudentMark[] students = new StudentMark[count];

            StudentMark sm = new StudentMark();
            for (int i = 0; i < count; i++)
            {
                sm.name = Console.ReadLine();
                sm.tamil = Convert.ToInt32(Console.ReadLine());
                sm.english = Convert.ToInt32(Console.ReadLine());
                sm.maths = Convert.ToInt32(Console.ReadLine());
                sm.science = Convert.ToInt32(Console.ReadLine());
                sm.socialscience = Convert.ToInt32(Console.ReadLine());
               
                students[i] = sm;
               

            }
        }
        
        

        
       

       
    }
}
