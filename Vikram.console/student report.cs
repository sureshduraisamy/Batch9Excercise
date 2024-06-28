using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vikram.console
{
    class StudentReport
    {
        public void CalculateTotal()
        {
            string studentName = "vikram";
            int tamil = 86;
            int english = 70;
            int maths = 70;
            int science = 95;
            int socialscience = 100;
            int total=tamil+english+maths+science+socialscience;
            Console.WriteLine("StudentName:"+studentName);
            Console.WriteLine("Total:"+total);

        }

    }
}
