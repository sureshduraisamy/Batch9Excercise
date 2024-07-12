using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class calculation
    {
        int count;

      public void Total()
      {
            count = Convert.ToInt32(Console.ReadLine());

            StudentMarks[] students = new StudentMarks[count];


            for (int i = 0; i <= 2; i++)
            {

                StudentMarks sm = new();
                sm.Name = Console.ReadLine();


                sm.Tamil = Convert.ToInt32(Console.ReadLine());
                sm.English = Convert.ToInt32(Console.ReadLine());
                sm.Maths = Convert.ToInt32(Console.ReadLine());
                sm.Science = Convert.ToInt32(Console.ReadLine());
                sm.SocialScience = Convert.ToInt32(Console.ReadLine());

                students[i] = sm;





            }

       


            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(students[i].Name);
                Console.WriteLine(students[i].Tamil);
                Console.WriteLine(students[i].English);
                Console.WriteLine(students[i].Maths);
                Console.WriteLine(students[i].Science);
                Console.WriteLine(students[i].SocialScience);







            }








      }





































    }
}
