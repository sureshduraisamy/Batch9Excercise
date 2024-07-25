using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraneshBusinessLayer
{
    class Wordcount
    {

        public static reversword (string a) 
        {
            string result = "";
            string currectword = "";
            for (int i=0; i < a.Length; i++) 
            {

                if (a[i]! = 'b') 
                {

                    currectword = a[i] + currectword;

                
                }
            else 
                {
                    result += currectword;
                    currectword = "";
                
                
                }
            
            
            }
            return  result;
           


            
                 

        }

        public int countwords(string a) 
        {
            int count = 0;
            bool inword = false;
            for (int i = 0; i < a.Length; i++) 
            {
                if (a[i] != 'b')
                {
                    if (!inword)
                    {
                        count++;
                        inword = true;







                    }

                }
                 else 
                {
                    inword = false;
                
                
                
                }
                


            }

            return count;

        }


    }
}
