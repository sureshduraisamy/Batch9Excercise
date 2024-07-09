using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class OddOrEven
    {
        public OddOrEven()
        {
            for (int Odd = 50; Odd! >= 1; Odd--)
            {
                Console.WriteLine(Odd);

                if (Odd % 2 == 0)
                {
                    Console.WriteLine("Odd" + Odd);
                }
            }

            for (int Even = 1; Even != 50; Even++)
            {
                Console.WriteLine(Even);


                if (Even % 2 != 0)

                {

                    Console.WriteLine("Even" + Even);




                }











            }





        }
    }
}
