﻿using System;

namespace Sample.ConsoleApp
{
    class BiggestNumber
    {

        public void BiggestNumb()
        {

            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());

            if(firstValue > secondValue)
            {
                Console.WriteLine("The Biggest Number is");
                Console.WriteLine(firstValue);
            }
            else
            {
                Console.WriteLine("The Biggest Number is");
                Console.WriteLine(secondValue);
            }

        }

    }
}
