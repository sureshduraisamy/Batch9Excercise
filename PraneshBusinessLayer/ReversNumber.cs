﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraneshBusinessLayer
{
   public  class ReversNumber
    {
        
        
        public void Number() 
        {
           int  a = 23456789;
            
            while (a > 0)
            {
                int last = a % 10;
                a = a / 10;
                Console.Write(last);

            }
            


        }





    }
}
