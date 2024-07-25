using System;
using System.Collections.Generic;


namespace numberreverse
{
    public class numReversing
    {
        int num = 1234;
        public void Numberev()
        {
            while (num > 0)
            {
                int last = num % 10;
                num = num / 10;
                Console.Write(last);
            }
        }
    }
}
