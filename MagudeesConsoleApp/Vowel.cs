﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class VowelsCount
    {
       

        public void count()
        {
            string s = "i am rohit";
            string voewl = "a,e,i,o,u";
            int count = 0;

            for(int i = 0; i < voewl.Length; i++)
            {
                count = 0;
                for (int k = 0; k < s.Length; k++)
                {
                    if (s[k] == voewl[i])
                    {
                        count++;
                    }



                }
                Console.WriteLine(voewl[i] + "," + count);
               









            }



















        }
    }
}

      













    

