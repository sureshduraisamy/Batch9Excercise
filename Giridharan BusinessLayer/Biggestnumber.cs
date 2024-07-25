using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
  public  class Biggestnumber
    {
       public int[] Numbers = { 80, 90, 30, 50, 85, 70 };
        public int temp = 0;
        public void Biggest()
        {
           
            for(int i = 0; i < Numbers.Length - 1; i++)
            {
                if (Numbers[i] > Numbers[i + 1])
                {
                    temp = Numbers[i];
                    Numbers[i] = Numbers[i + 1];
                    Numbers[i + 1] = temp;
                }
                else
                {
                    temp = Numbers[i + 1];
                }
            }
            Console.WriteLine(Numbers[Numbers.Length-1]);
        }
        public void Ternary()
        {
            int a = 30;
            int b = 50;
            int c = a > b ? a : b;
            Console.WriteLine(c);
        }
         
    }
}
