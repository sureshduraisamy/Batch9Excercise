using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraneshBusinessLayer
{
    public class StringRevers
    {
        string a = "pranesh";
        string b = " ";

        public void Revers() 
        {
          for(int i = a.Length; i > 0; i--)
            {
                b = b + a[i-1];
            }
            Console.WriteLine(b);
        }

    }
}
