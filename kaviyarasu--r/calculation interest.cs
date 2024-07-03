using System;
namespace LoanInterestcalculation
{
    class calculation_interest {
        public int LoanAmount;
        public int Loantentures;
        int interestrate = 12;
        public void Interest()
        {
            Console.WriteLine("enter LoanAmount");
             LoanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Loantenture");
            Loantentures = Convert.ToInt32(Console.ReadLine());
        }
        
        public void Compoundinterest()
         {
            int userinterest = (LoanAmount *interestrate * Loantentures/12)/100;
            Console.WriteLine(userinterest);
        }
    }
}

       
