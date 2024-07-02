using System;

namespace ConsoleApp1
{
    class StudentMarksheet
        {

        public void calculateTotal()
        {
            string studentName = "Pranesh";
            int english = 80;
            int tamil = 90;
            int maths = 70;
            int science = 97;
            decimal  total = english + tamil + maths + science;
            Console.WriteLine("Total marks=" +total);
            Console.WriteLine("Student name=" +studentName);
            decimal percentage = (total / 400 * 100);
            Console.WriteLine(percentage);


        }
        public int age = 50;

        public void read()
        {
            age = 50;
            int total = 360;
            Console.WriteLine(total = 100);
        }
            }
}