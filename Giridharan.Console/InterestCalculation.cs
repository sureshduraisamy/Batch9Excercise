using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class InterestCalculation
    {
        
       public int amount;
       public int interestrate;
       public int year;
        public void GetData() 
        { 

            Console.WriteLine("Enter Your Loan Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Duration Period (year)");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Tnterest Rate(in %)");
            interestrate = Convert.ToInt32(Console.ReadLine());  
        }
        public void Interest()
        {
            int interest = (amount * interestrate * year) / 100;
            Console.WriteLine(interest);
        }
    }
}
