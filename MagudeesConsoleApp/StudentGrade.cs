using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class StudentGrade
    { 
        public void studentmarks()
        {

            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("tamil");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("english");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maths");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("science");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("socialscience");
            int socialscience = Convert.ToInt32(Console.ReadLine());
            int Total = tamil + english + maths + science + socialscience;
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Total" + Total);
      
            if (Total >= 490 && Total <= 500)
            {
                Console.WriteLine("your grade is A");
            }
            else if(Total < 490 && Total >= 450)
            {
                Console.WriteLine("youe grade is B");
            }
            else if(Total >450 && Total <= 400)
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
