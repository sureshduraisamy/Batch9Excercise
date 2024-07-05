using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class StudentReport
    {
        public string Studentname;
        public int studentmark;


        public void totalmark()
        {
            Console.WriteLine("studentname");
            Studentname  = (Console.ReadLine());
            Console.WriteLine("tamil");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("english");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maths");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("science");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("socialscience");
            int socailscience = Convert.ToInt32(Console.ReadLine());
            studentmark  = tamil + english + maths + science + socailscience;
            Console.WriteLine("studentname"+Studentname );
            Console.WriteLine("total"+studentmark );


        }



        public void markcheck()
        {

            Console.WriteLine("total mark of" + " " + Studentname + " " + studentmark);
            if (studentmark > 400 && studentmark < 450)
            {
                Console.WriteLine(Studentname + " " + " has secured C Gread");
            }
            else if (studentmark > 450 && studentmark < 490)
            {
                Console.WriteLine(Studentname + " " + " has secured B Gread");
            }
            else if (studentmark > 490 && studentmark < 500)
            {

                Console.WriteLine(Studentname + " " + " has secured A Gread");
            }
            else
            {
                Console.WriteLine(Studentname + " " + " has secured D Gread");

            }


        }


















        
        
        
        
        




    }
}
