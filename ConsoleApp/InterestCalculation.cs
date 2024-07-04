using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class InterestCalculation
    {
        string name;
       decimal interestRate;
        decimal amount;
        decimal time;

        public void GetData()
        {
            Console.WriteLine("enter ur name");
            name= Console.ReadLine();
            Console.WriteLine("interest rate");
            interestRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter the amount");
            amount =Convert.ToDecimal(Console.ReadLine());
       
            time = Convert.ToDecimal(Console.ReadLine());
        }

        public void TotalAmount()
        {
            decimal si;
            si = (amount * interestRate*(time/12))/100;
            Console.WriteLine(si);
           
        }

    }
}
