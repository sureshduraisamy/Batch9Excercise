using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class Calculation
    {

        string Name;
        int age;
        int pricipalamount;
        int intrestrate;
        int years;



        public void Amount()
        {
            Console.WriteLine("Enter the name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the pricipalamount");
            pricipalamount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the intrestrate");
            intrestrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("years");
            years = Convert.ToInt32(Console.ReadLine());

        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(age);
            Console.WriteLine(pricipalamount);
            Console.WriteLine(intrestrate);
            Console.WriteLine(years);


        }
    }
}
























        }
    }

}
}
