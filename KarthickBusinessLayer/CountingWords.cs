using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
   public class CountingWords
    {
        string str = "I am karthick s. age";
        public CountingWords()
        {
           
            string[] var= str.Split(" ");
           
            Console.WriteLine(var.Length);
        }
        public int count=0;

        public void Counting()
        {
            for (int i=0;i<str.Length-1;i++)
            {
                if(str[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count+1);
        }



    }
}
