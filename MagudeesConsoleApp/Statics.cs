using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    
        
         static class Statics
        {
           static int  count = Convert.ToInt32(Console.ReadLine());


            public static string name = "Magudees";
            public static int age = 20;
            public static long phonenumber = 8883814380;

            public static void detail()
            {
        

                for(int i=0; i <2; i++)
                {
                    Console.WriteLine(name);
                    Console.WriteLine(age);
                    Console.WriteLine(phonenumber);

                }


            }








        } 

        
    
}
