using System;
using BusinessLayer;
namespace Sample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                RegistrationService resSer = new RegistrationService();
                resSer.GetUserRegistrationInformation();

                //MemberResgirtation ob = new MemberResgirtation(8, "syre");
                //ob.RegisterUser();

                //ParamandReturnType param = new ParamandReturnType();
                //param.Addition();
                //param.Addition(69, 80);
                //string v = param.Addition(38,'m',"Suresh");
                //Console.WriteLine(v);

                //BiggestNumber big = new BiggestNumber();
                //big.BiggestNumb();

                //ReadData obj = new ReadData();
                //obj.GetData();
                //obj.PrintData();
                //Arithmetic ovj = new Arithmetic();
                //ovj.Addtiion();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Check your arry size");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Went wrong . PLease contact admin");
            }
            finally { 

            }

        }

       
    }
}
