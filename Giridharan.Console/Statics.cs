using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    static class Statics
    {

        public static bool Isvalidnumber(this string a)
        {
            bool value = false;
            if (a.Length == 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (a[i] == '9' || a[i] == '1' || a[i] == '3' || a[i] == '5' || a[i] == '8' || a[i] == '9' || a[i] == '1' || a[i] == '3' || a[i] == '5' || a[i] == '8')
                    {
                        value = true;
                    }
                    else
                    {
                        value = false;
                    }

                }
            }
            return value;
        }
                
        
        public  static void Details()
        {
            string name = "Giri";
            bool contains = name.Contains('G');
            int age = 23;
            
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(contains);
            Console.WriteLine(number);
            
       }
        public static long number
        {
            get
            {
                return 98455683;
            }
          
        }
       

        
        
    }
    
}
