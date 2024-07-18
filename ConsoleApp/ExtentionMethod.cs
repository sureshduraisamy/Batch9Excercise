using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
   static  class ExtentionMethod
    {
       
        public static bool IsMobileNo(this string num)
        {
            bool value = false;
            if (num.Length == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    if ((num[i] == '1') || (num[i] == '2') || (num[i] == '3') || (num[i] == '4') || (num[i] == '5') || (num[i] == '6')
                        || (num[i] == '7') || (num[i] == '8') || (num[i] == '9') || (num[i] == '0'))
                    {
                        value = true;
                    }
                    else
                    {
                        value = false;
                        break;
                    }
                }
            }
            return value;
        }

    }
}
