using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarmanBusinesslayer
{
   public class CountingWords
    {
        String str = "I am kavi";
        public void Words()
        {
            String[]var= str.Split(" ");
           
            Console.WriteLine(var.Length);
            
        }
        public int count = 0;
        public void countind()
        {
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    count++;
                }
                
            }
            Console.WriteLine(count + 1);
        }
    }
}
