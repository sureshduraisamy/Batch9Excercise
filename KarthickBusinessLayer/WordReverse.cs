using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
   public class WordReverse
    {
        string str = "I am karthick", strOne,rev,sol;
      
        
        public void Word_Reverse()
        {
            
            for (int i=str.Length-1;i>=0;i--)
            {
                strOne += str[i];
                if (str[i] == ' '||i==0) 
                {
                   
                    for (int j = strOne.Length-1; j >= 0; j--)
                    {
                       rev +=strOne[j] ;
                    }
                    strOne = " ";
                    sol = rev;
                   
                
                }
            }
            Console.WriteLine(rev.Trim()) ;
            Console.WriteLine(sol.Trim(' '));
        }
    }
}
