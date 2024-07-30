using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
   public  class Exceptions
    {
        string A = "hi this is vikram";
        string B;
        public void words()
        {
            string[] data = A.Split(' ');
            for(int i = data.Length; i > 0; i--)
            {
                B = B + data[i];

            }
            Console.WriteLine(B);
        }
    }
}
