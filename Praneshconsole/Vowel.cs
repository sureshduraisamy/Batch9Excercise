using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class Vowelcount
    {
        char a;
        public void vowel ()
        {
            Console.WriteLine("enter alphabet letter");

            a = Convert.ToChar(Console.ReadLine());
            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                Console.WriteLine("letter enter is vowel");
            }
            else

                Console.WriteLine("letter is notvowel");

            }    
  
            


               

        


    }
}
