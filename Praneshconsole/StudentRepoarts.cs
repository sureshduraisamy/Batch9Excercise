using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praneshconsole
{
    class StudentRepoarts
    {
     public void CalculaTetotal()
        {
            String Student = "pranesh";
            int tamil1=90;
            int english2=90;
            int maths3=75;
            int science4=65;
            int social5 = 55;
            decimal  Total = tamil1 + english2 + maths3 + science4 + social5;
            Console.WriteLine("StudentName="+Student);
            Console.WriteLine("Total="+Total);
            decimal percentage = (Total / 500 * 100);
            Console.WriteLine(percentage);

        }
    }
}
