using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarman.console
{
    class ProgramQuestion
    {
        String temp = "*";
        public void Program()
        {
            for(int j = 10; j >=0 ; j--)
            {
                for(int i = j; i > 0; i--)
                {
                    Console.Write(temp);
                }
                Console.WriteLine();
            }
            
        }
    }
    
}
