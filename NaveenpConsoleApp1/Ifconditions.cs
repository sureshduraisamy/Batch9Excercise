using System;


namespace Conditionalstatement
{
    class Conditions
    {
        public void ifcondition()
        {
            Console.WriteLine("enter a number");
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number");
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            if (firstvalue > secondvalue)
            {
                Console.WriteLine("the biggest number is " + firstvalue);
            }
            else
            {
                Console.WriteLine("the biggest number is " + secondvalue);
            }


        }

        public void Evenorodd()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 ==0 ) 
            {
                Console.WriteLine("the number is even");
            }

            else
            {
                Console.WriteLine("the number is odd");
            }
            
            
          

            
            

           

            
        }
        public void Simple()
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number");
            int b = Convert.ToInt32(Console.ReadLine());
             int c = a / b;
            int d = a % b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            
        }
        public void Leapyear()
        {
            Console.WriteLine("enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0) 
                    {
                Console.WriteLine("the year is leapyear");
                     }
            else
            {
                Console.WriteLine("the year is not a leap year");
            }

        }

    }
}
