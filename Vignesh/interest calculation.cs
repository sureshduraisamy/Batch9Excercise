using System;


namespace LoanInterestcalculation
{ 
class interestcalculation
    {
        public int LoanAmount
        public int loanTenture;
        public int Interestrate;
        public void interest()
        {
            Console.WriteLine("enter LoanAmount");
            LoanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Loantenture");
            loanTenture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Interestrate");
            Interestrate = Convert.ToInt32(Console.ReadLine());


        }
        public void Compoundinterest()
        {
            int userinterest = (LoanAmount * Interestrate * loanTenture |/ 100 ;
            Console.WriteLine(userinterest);

        }
    }


























}
