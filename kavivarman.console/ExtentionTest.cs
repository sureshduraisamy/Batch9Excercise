using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarman.console
{
    class ExtentionTest
    {public void number()
        {
            String mobile = "1234567890";
            bool str = mobile.MobileNo();
            Console.WriteLine(str);
        }
    }
}
