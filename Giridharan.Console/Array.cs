using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class Array

    {
        
        
        string[] name = new string[10];
            
        
        public Array()
        {
            
           
            for(int s = 0; s < 10; s++)
            {
                name[s] = Console.ReadLine();
                
            }
            Console.WriteLine(name);

        }

    }
}
