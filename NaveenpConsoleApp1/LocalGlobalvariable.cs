using System;

namespace collegestrength
{
    class sections

    {
        public string collegename = "karunya";
        public int totaldepartment = 2;
        public int ecestaff = 10;
       

        public void Electrical()
        {
            int totalStudents = 150;
            string departmentName = "ECE";
            int Ecestaffs = 10;
            Console.WriteLine(collegename + departmentName);
            Console.WriteLine(totalStudents);
        }
        public void Computer()
        {
            int totalStudents = 350;
            string departmentName = "CSE";
            Console.WriteLine(collegename + departmentName);
            Console.WriteLine(totalStudents);

        }
    }



}

