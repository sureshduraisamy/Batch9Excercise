using System;
using Calculator;
using studentMark;
using LoanInterestcalculation;

namespace kaviyarasu__r
{
    /*class Program
    {
        static void Main(string[] args)
        {
            Arithmetic Add = new Arithmetic();
                Add.Addition();
        }
    }*/

    class bankloan
    {
        static void Main(string[] args)
        {
            calculation_interest data = new calculation_interest();
            data.Interest();
            data.Compoundinterest();

        }

    }
}
