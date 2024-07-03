using System;


namespace LoanInterestcalculation
{
    class Interestcalculation
    {
        public int LoanAmount;
        public int LoanTenture;
        public int interestrate ;
        public void Interest()
        {
            Console.WriteLine("enter LoanAmount");
            LoanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Loantenture");
            LoanTenture = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter interestrate");
            interestrate = Convert.ToInt32(Console.ReadLine());






        }
        public void Compoundinterest()
        {
            int userinterest = (LoanAmount * interestrate *LoanTenture)/100 ;
            Console.WriteLine(userinterest);

        }
        

    }
}
