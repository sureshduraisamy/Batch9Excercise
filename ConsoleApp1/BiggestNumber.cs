using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BiggestNumber
    {
        int maths;
        int tamil;

        public void bigger()
        {
            Console.WriteLine("Maths=");
            maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tamil=");
            tamil = Convert.ToInt32(Console.ReadLine());
        }

        public void greatnumber()
        {
            if (maths > tamil)
            {
                Console.WriteLine("The Biggest Mark is Maths");
                Console.WriteLine(maths);
            }
            else
            {
                
                Console.WriteLine("The Biggest Mark is Tamil");
                Console.WriteLine(tamil);

            }
            
                
            
        }

    }
}
 