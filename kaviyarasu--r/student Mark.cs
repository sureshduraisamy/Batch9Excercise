using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentMark
{
    class student_Mark
    {
        public void Totalmark()
        {
            string Name = "kaviyarasu";
            int maths = 90;
            int science = 90;
            int social = 85;
            decimal subjecttotal = (maths + science + social);
            Console.WriteLine("studentName=" + Name);
            Console.WriteLine("totalMark="+subjecttotal);
            decimal percentage = (subjecttotal / 300 * 100);
            Console.WriteLine("percentage=" + percentage);
        }


       
    }     
}        
   
