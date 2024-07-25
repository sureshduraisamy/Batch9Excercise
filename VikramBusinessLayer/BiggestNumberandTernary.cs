using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
    public class BiggestNumberTernary
    {
        int Final;
        public void Checked()
        {
            Console.WriteLine("enter count of numbers");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];

            for (int j = 0; j < count; j++)
            {
                Console.WriteLine("enter the numbers");
                numbers[j] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Final = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = Final;



                }

            }
            Console.WriteLine(Final);
        }
        public void Checkternary()
        {
            int a = 75;
            int b = 35;
            int c = a > b ? a : b;
            Console.WriteLine(c);




        }




    }
}
    

