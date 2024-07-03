using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class Interest_calculation
    {
        int netamount;
        int interestrate;
        int years;
        public void interest()
        {
            Console.WriteLine("Enter the net amount");
            netamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no.of years");
            years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter interest rate(in %)");
            interestrate = Convert.ToInt32(Console.ReadLine());
        
        } 
        
        public void calculate()
        {
            Console.WriteLine("details");
            Console.WriteLine(netamount * years / 100) ;
        
        
        
        
        
        }







    }
}
