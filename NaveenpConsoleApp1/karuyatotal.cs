using System;

namespace collegestrength
{
    class sectionsofcollege

    {
        public string collegename = "karunya";
        public int totalsdepartment = 2;
        public int mechstaff = 10;
       

        public void Mechanical()
        {
            int totalStudents = 100;
            string departmentName = "MECH";
            Console.WriteLine(collegename + departmentName);
            Console.WriteLine(totalStudents);
        }
        public void Civil()
        {
            int totalStudents = 80;
            string departmentName = "Civil";
            Console.WriteLine(collegename + departmentName);
            Console.WriteLine(totalStudents);

        }
    }



}

