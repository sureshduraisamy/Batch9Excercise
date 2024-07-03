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
        int interestRate;
        int amount;
        int time;

        public void GetData()
        {
            Console.WriteLine("enter ur name");
            name= Console.ReadLine();
            Console.WriteLine("interest rate");
            interestRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount");
            amount =Convert.ToInt32(Console.ReadLine());
       
            time = Convert.ToInt32(Console.ReadLine());
        }

        public void TotalAmount()
        {
            int si;
            si = (amount * interestRate*(time))/100;
            Console.WriteLine(si);
           
        }

    }
}
