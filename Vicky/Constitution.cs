using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicky
{
    class Constitution
    {
       public int count = 0;

        public Canditate[] Enterdetails (Canditate D)
        {
            count = Convert.ToInt32(Console.ReadLine());
            Canditate[] arr = new Canditate[count];

            for (int i = 0; i < count; i++)
            {
                Canditate c = new();
                c.name = Console.ReadLine();
                c.constitution = Console.ReadLine();
                c.age = Convert.ToInt32(Console.ReadLine());
                
                arr[i] = c;

            }

           


            return arr;
        }
    }
}
