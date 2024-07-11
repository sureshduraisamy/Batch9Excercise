using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveendevi.consol
{
    class Student_Mark
    {
        public string name;
        public int tamil  ;
        public int english ;
        public int maths ;
        public int science ;
        public int cs ;
        public int eg;
        
        
      public Student_Mark()
        {

            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No.of.Student:" + count);
            string name = Console.ReadLine();
            Console.WriteLine("Name+name");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tamil;+tamil");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("English;+english");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maths;+maths");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Science;+science");
            int cs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("cs;+cs");
            int Total = tamil + english + maths + science + cs;
            Console.WriteLine("total+total");





































        }






    }
}
