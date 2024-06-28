using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class StudentReport
    {
        public void CalculateTotal()
        {
            string studentName = "Giridharan";
            int tamil = 93;
            int english = 80;
            int maths = 70;
            int biology = 60;
            int physics = 80;
            int chemistry = 70;
            int total = tamil + english + maths + biology + physics + chemistry;
            Console.WriteLine("Student Name:"+studentName);
            Console.WriteLine("Total:"+total);
        }
    }
}
