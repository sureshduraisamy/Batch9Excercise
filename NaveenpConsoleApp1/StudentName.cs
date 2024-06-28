using System;

namespace StudentName
{
    class Studenttotal
    {
        public void Totalmark()
        {
            string nameofstudent = "Naveen";
            int maths = 90;
            int science = 90;
            int tamil = 85;
            int english = 90;
            decimal subjecttotal = (maths + science + tamil + english);
            Console.WriteLine("studentname ="+nameofstudent);
            Console.WriteLine("totalmark ="+subjecttotal);
            decimal percentage = (subjecttotal / 400*100);
            Console.WriteLine("percentage ="+percentage);




        }
    }
}
