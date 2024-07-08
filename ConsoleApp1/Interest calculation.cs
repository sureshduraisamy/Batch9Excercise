using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Interest_calculation
    {
        string name;
        int age;
        int pricipalamount;
        int intrestrate;
        int years;


        public void calculate()
        {
            Console.WriteLine("Enter your name");
          name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
          age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entet principal amount");
          pricipalamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No.of years");
           years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter intrest rate(in %)");
           intrestrate = Convert.ToInt32(Console.ReadLine());

        }

        public void Interest()
        {
            Console.WriteLine("DETAILS OF THE ACCOUNTANT");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(pricipalamount * ( years * 12 ) * intrestrate / 100);

        }

    }
}
