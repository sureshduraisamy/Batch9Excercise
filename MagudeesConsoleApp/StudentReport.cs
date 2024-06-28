using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class StudentReport
    {
        public void CalculateTotal()
        {


            string studentName = "vicky";
            int subject1 = 75;
            int subject2 = 80;
            int subject3 = 65;
            int subject4 = 85;
            decimal Total = subject1 + subject2 + subject3 + subject4;
            Console.WriteLine("StudentName:"+studentName);
            Console.WriteLine("Total:"+Total);
            decimal percentage = (Total / 400 * 100);
            Console.WriteLine(percentage);
        }

        
    }
}
