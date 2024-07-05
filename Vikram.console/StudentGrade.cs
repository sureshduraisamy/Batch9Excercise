using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class StudentGrade
    {
       
        public void Grade()
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Tamil Mark:");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your English Mark:");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Maths Mark:");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your science Mark:");
            int science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your social science Mark:");
           int socialscience = Convert.ToInt32(Console.ReadLine());
            int total = tamil + english + maths + science + socialscience;
            Console.WriteLine("Name:"+name);

            Console.WriteLine("Total:"+total);
            
            if (total >= 490 && total<= 500){
                Console.WriteLine("Your grade is A");


            }
            else if(total<490 && total>450)
            {
                Console.WriteLine("Your grade is B");
            }
            else if(total<450 && total > 400)
            {
                Console.WriteLine("Your grade is C");
            }
            else
            {
                Console.WriteLine("Your Grade is D");
            }
        }
        
        


        

    }
}
