using System;
using System.Collections;


namespace Userdefinedfun
{
    class Markdetails

    {
        
        int count = Convert.ToInt32(Console.ReadLine());
        public void Calculation()
        {

            Studentsmark[] students = new Studentsmark[count];
            

            for (int i = 0;i<count;i++)
            {
                Console.WriteLine("enter student details");
                Studentsmark sm = new Studentsmark();

                sm.name = Console.ReadLine();
                sm.Tamil = Convert.ToInt32(Console.ReadLine());
                sm.Maths = Convert.ToInt32(Console.ReadLine());
                sm.English = Convert.ToInt32(Console.ReadLine());
                sm.Science = Convert.ToInt32(Console.ReadLine());
                sm.Social = Convert.ToInt32(Console.ReadLine());
                students[i] = sm;
                
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(students[i].name);
                Console.WriteLine(students[i].Tamil);
                Console.WriteLine(students[i].Maths);
                Console.WriteLine(students[i].English);
                Console.WriteLine(students[i].Science);
                Console.WriteLine(students[i].Social);
            }
            
            





        }

    }
}
