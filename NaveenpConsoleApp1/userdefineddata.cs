using System;
using System.Collections;


namespace Userdefinedfun
{
    class Markdetails

    {
        int total;
        

        int students;
        public void Calculation()
        {
            Console.WriteLine("enter the number of student details to be fetched");
            int count = Convert.ToInt32(Console.ReadLine());

            Studentsmark[] students = new Studentsmark[count];

            for (int i = 0; i < count; i++)
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
                Console.WriteLine("enter student name");
                Console.WriteLine(students[i].name);
                Console.WriteLine("enter tamil mark");
                Console.WriteLine(students[i].Tamil);
                Console.WriteLine("enter maths mark");
                Console.WriteLine(students[i].Maths);
                Console.WriteLine("enter english mark");
                Console.WriteLine(students[i].English);
                Console.WriteLine("enter science mark");
                Console.WriteLine(students[i].Science);
                Console.WriteLine("enter social mark");
                Console.WriteLine(students[i].Social);
            }
            
        
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("total mark of" + " " + students[i].name);
                total = (students[i].Tamil + students[i].Maths + students[i].English + students[i].Science + students[i].Social);
                if (total >= 490 && total <= 500)
                {
                    Console.WriteLine(students[i].name + "  " + "has secured A Grade ");
                }
                else if (total >= 450 && total < 490)
                {
                    Console.WriteLine(students[i].name + "  " + "has secured B Grade ");
                }
                else if (total >= 400 && total < 450)
                {
                    Console.WriteLine(students[i].name + "  " + " has secured C Grade ");
                }
                else
                {
                    Console.WriteLine(students[i].name + "  " + "  has secured D Grade");
                }
            }
        }










    }  
}

