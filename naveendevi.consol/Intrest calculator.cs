using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveendevi.consol
{
    class Intrest_calculator
    {
        
        int loanamount;
        int intrest;
        int year;

        public void GetData()
        {
            Console.WriteLine("loanamount");
            
            loanamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("duration period(year)");
           year= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("intrest value");
            intrest = Convert.ToInt32(Console.ReadLine());
        }
        public void compoundintrest()
        {


            int userintrest = (loanamount * intrest * year) / 100;

            Console.WriteLine(loanamount);

        }
           

    }
}
        
            

