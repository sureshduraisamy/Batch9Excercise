using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
   public class Palindrome
    {
       public string str = "malayalam",rev="";
       public Palindrome(){
        for(int i=0;i<str.Length;i++)
            {
                rev +=str[i];
            }
            Console.WriteLine(rev);
            if (str==rev)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("is not palinndrome");
            }
                          }
    }
}
