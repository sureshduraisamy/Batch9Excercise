using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
  public  class Wordcount
    {
        string b = "I am giri";
        char v = 'b';
        public string Reversewords(string a)
        {
            
            string result = "";
            string currentword = "";
            for(int i = 0; i < b.Length; i++)
            {
                if (b[i] != v)
                {
                    currentword = b[i] + currentword;
                }
                else
                {
                    result += currentword;
                    currentword = "";
                }
                
            }
            result += currentword;
            return result;
          
        }
        public int Countwords(string a)
        {
            int count = 0;
            bool inword = false;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != v)
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
