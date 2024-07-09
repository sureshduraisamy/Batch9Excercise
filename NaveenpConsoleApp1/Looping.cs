using System;


namespace Loopingstate
{
    class Forlooping
    {
       public int evennum;
        public Forlooping()
        {
            
            for (evennum = 0 ; evennum<=50; evennum++ )
            {
                if (evennum % 2 == 0)
                {
                    Console.WriteLine(evennum);
                }
               

            }

        }
    }

    class Oddlooping
    {
        public int oddnum;
        public Oddlooping()
        {
            for (oddnum = 50; oddnum >= 0; oddnum--)
            {
                if (oddnum % 2 != 0)
                {
                    Console.WriteLine(oddnum);
                }
            }
        }
    }
    class Twotable
    {
        public int Tablenum;
        public Twotable()
        {
            for(Tablenum = 0; Tablenum <= 20; Tablenum++)
            {
                Console.WriteLine("2x"+Tablenum+"="+Tablenum * 2);
            }
        }
    }

    class Examples
    {
        public void Loopexamples()
        {
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("c# no.of iterations" + i);
            }
                
        }
        //SUM OF FIRST 10 NATURAL NUMBERS
        public void Naturalnumber()
        {
            int number;
            int sum = 0;
            for(number = 1; number <= 10; number++)
            {
                sum = sum + number;
                Console.WriteLine("the sum of number are" + sum);
            }

        }
    }
}
