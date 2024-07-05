using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicky
{
    class studentgrade
    {
        public string studentname;
        public int studentmark;


        public void totalmark() 
        {
            Console.WriteLine("studentname");
            studentname = Console.ReadLine();
            Console.WriteLine("maths");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("english");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tamil");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("science");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("socialscience");
            int socialscience = Convert.ToInt32(Console.ReadLine());
            int total = maths + english + tamil + science + socialscience;
            Console.WriteLine("Name:" + studentname);
            Console.WriteLine("total:" + total);

            if (total >= 490 && total <= 500)
            {
                Console.WriteLine("your grade is A");
            }
            else if (total < 490 && total >= 450)
            {
                Console.WriteLine("your grade is B");
            }
            else if (total < 450 && total >= 400) 
            {
                Console.WriteLine("your grade is C");
            }
            else
            {
                Console.WriteLine("your grade is D");
            }
            
        }
     




        



      









    }
     
}
