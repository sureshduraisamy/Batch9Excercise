using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarmanBusinesslayer
{
  public  class WordReverse
    {

        String str = "I am kavi", strone, rev, sol;
        
        
        public void Words()
        {
            
            for(int i = str.Length-1; i >= 0; i--)
            {
                
                    strone+= str[i];
                if (str[i] == ' ' || i == 0)
                {
                    for(int j = strone.Length - 1; j >= 0; j--)
                    {
                        rev += strone[j];
                    }
                    strone = " ";
                    sol = rev;
                }
              
            }
            Console.WriteLine(rev.Trim());
        }
        
    }
}
