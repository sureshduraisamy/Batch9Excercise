using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vikram.console
{
    class IntrestCalculation
    {
        int amount;       
        int intrest_rate;
        int years;

        public void GetData()
        {
            Console.WriteLine("Enter the  Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No.of years");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter intrest rate(%)");
            intrest_rate = Convert.ToInt32(Console.ReadLine());
        }
        public void Intrest()
        {
            Console.WriteLine(amount * years * intrest_rate / 100);

        }
              
        

       
    }
}
