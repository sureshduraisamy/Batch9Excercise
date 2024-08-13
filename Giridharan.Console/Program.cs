using System;
using Giridharan_BusinessLayer;

namespace GiridharanConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistrationService resser = new RegistrationService();
               resser.MenuDriven();
               // EmployeesDetails obj = new();
                //obj.Details();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }



           // WordReverse obj = new();
            //Reversing obj1 = new();
            //obj.Reverse();
            //obj1.Word();



           // WordCount obj = new();
            //Counting obj1 = new();
            //obj.Count();
            //obj1.Countsword();
            




           // Reversenumber obj = new();
           // obj.Numbers();


           // Biggestnumber obj = new();
            //obj.Biggest();



           // Child obj = new Child();
            //obj.M2(10);
            


           // Childclass obj = new Childclass();
           // obj.Studentdetails();



            //Vowelscount obj = new Vowelscount();
            //obj.Vowels();

            //Statics.Details();
       


           // constuct obj = new constuct();
            //constuct obj1 = new constuct( 10);



           // Iterate obj = new Iterate();
           //obj.RowsandColums();
            //obj.RowsandColumn1();




            //Course obj = new Course();
            //obj.Details();
           // Candidate obj = new Candidate();
            //obj.name = Console.ReadLine();
          
            //Details s = new Details();

          //  Candidate[] b = s.EnterDetails(obj);


           // for(int i=0;i<s.count;i++)
          //  {
            //    Console.WriteLine(b[i].name);
            //    Console.WriteLine(b[i].constitution);
           //     Console.WriteLine(b[i].age);
               
          //  }




           // Marklist obj = new Marklist();
            //obj.Calculation();
            


            // Array obj = new Array();
            // Odd_OR_Even obj= new();


            // StudentGrade obj = new();
            // obj.Grade();




            // BiggestNumber obj = new();
            //obj.BiggestNum();
            //obj.Add_Or_Even();
            //obj.LeapYear();




            // InterestCalculation obj = new();
            //obj.GetData();
            //obj.Interest();


            // StudentMarklist obj = new StudentMarklist();
            //obj.Report();











            // PersonAge obj = new PersonAge();
            //PersonName obj1 = new PersonName();
            //obj.age = obj1.total;
            //Console.WriteLine(obj.age);
            //Console.WriteLine(obj1.total + 7);
            //obj.AgeDetails();
            //obj1.PersonDetails2();





            // StudentReport ovj = new StudentReport();
            //ovj.CalculateTotal();






            // PatientDetails Ovj = new PatientDetails();
            //Ovj.Name();

        }
    }
}
