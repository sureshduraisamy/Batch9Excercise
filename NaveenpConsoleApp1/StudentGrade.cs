using System;

namespace GradeSystem
{
    class StudentGrade
    {
        public string studentName;
        public int studentMark;
        
        

        public void TotalMark()
        {
            Console.WriteLine("Enter Student Name");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter maths marks");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter english marks");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tamil marks");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter science marks");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter social marks");
            int social = Convert.ToInt32(Console.ReadLine());
            studentMark = maths + english + tamil + science + social;
            

        }
        public void Markcheck()
        {

            Console.WriteLine("total mark of" + " " + studentName + " " + studentMark);
            
            if (studentMark >= 400 && studentMark < 450)
            {
                Console.WriteLine(studentName +"  "+ " has secured C Grade ");
            }
            else if (studentMark >= 450 && studentMark < 490)
            {
                Console.WriteLine(studentName +"  "+"has secured B Grade ");
            }
            else if (studentMark >= 490 && studentMark <= 500)
            {
                Console.WriteLine(studentName +"  " +"has secured A Grade ");
            }
            else if (studentMark > 500)
            {
                Console.WriteLine("invalid mark");
            }
            
            else
            {
                Console.WriteLine(studentName+"  "+"  has secured D Grade");
            }


        }

    }
}
