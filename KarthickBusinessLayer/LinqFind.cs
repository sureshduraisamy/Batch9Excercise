using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
  public  class LinqFind
    {
        List<string> val = new List<string>() {"karthick","mani","mani"};
        List<int> val1 = new List<int>() { 1,2 };
        public void Num() {
           int numer= val1.Single(a=> a==1);
            Console.WriteLine(numer);
            string str = val.Find(a=> a=="karthick");
            Console.WriteLine(str);

            List<string> num = val.FindAll(a=> a=="mani");
               
           
            foreach (string i in num)
            {
                Console.WriteLine(num);
            }
        }
       
    }
}
