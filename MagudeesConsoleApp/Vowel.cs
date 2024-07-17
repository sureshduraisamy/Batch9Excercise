using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class Vowel
    {
        char a;

      public void VowelFind()
      {
            Console.WriteLine("enter the alphabet letter");

            a = Convert.ToChar(Console.ReadLine());

            if (a == 'a'|| a =='e'|| a=='i'|| a =='o'|| a == 'u' )
            {
                Console.WriteLine("letter is vowel");
            }
            else
            {
                Console.WriteLine("letter is not vowel");
            }

           



      }













    }
}
