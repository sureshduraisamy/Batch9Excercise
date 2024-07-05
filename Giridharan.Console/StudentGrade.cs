using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class StudentGrade
    { 
        public void Grade()
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Tamil Mark:");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your English Mark:");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Maths Mark:");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Science Mark:");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your SocialScience Mark:");
            int socialscience = Convert.ToInt32(Console.ReadLine());
            int total = tamil + english + maths + science + socialscience;
            
            Console.WriteLine("Name:" + name);

            Console.WriteLine("Total:"+total);
            
             
            if (total >= 490 && total <= 500) 
            {
                Console.WriteLine("Your Grade is A");

            }
            else if (total < 490 && total >= 450)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (total <450 && total >= 400)
            {
                Console.WriteLine("Your Grade is C");
            }
            else
            {
                Console.WriteLine("Your Grade is D");
            }


        }
        
        
           
        
    }
}
