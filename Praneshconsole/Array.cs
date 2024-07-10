using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class Array
    {
        int[] value = new int[5];
        public Array() 
        {
           




            
            {
                for (int i = 1; i < 5; i++)
                {
                    value[i] = Convert.ToInt32(Console.ReadLine());
                        
       
                }

                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine(value[i]); 
                
                }
                int temp = 0;
                for (int i = 1; i < 5; i++)
                {
                    temp = temp + value[i];               
                }
                Console.WriteLine(temp);




            }
           
        
        }




    }
}
