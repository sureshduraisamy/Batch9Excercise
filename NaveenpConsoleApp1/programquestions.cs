using System;
using System.Collections.Generic;


namespace Programque
{
    class Printingque
    {
        string temp = "*";
       public void Question()
        {
            for (int A = 6; A >= 0; A++)
            {
                for(int B = 6; B >= 0; B++)
                {
                    Console.Write(temp);
                }
                Console.WriteLine();
            }
        }
    }
}
