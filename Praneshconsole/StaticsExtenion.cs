using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    static class StaticsExtenion
    {
        public static bool Inaadharno(this string s)

        {
            bool valu = false;
            if (s.Length == 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (s[i] == '0' || s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' || s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
                    {
                        valu = true;
                    }
                    else
                    {
                        valu = false;
                        break;
                    }
                }






            }
            return valu;
        }




    }

}   

