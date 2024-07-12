using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class Details
    {
       public int count = 0;
        public Candidate[] EnterDetails(Candidate D)
        {
            Console.WriteLine(D.name);

            count = Convert.ToInt32(Console.ReadLine());
            Candidate[] ar = new Candidate[count];
            for(int i = 0; i < count; i++)
            {
                Candidate m = new();
                m.name = Console.ReadLine();
                m.constitution = Console.ReadLine();
                m.age = Convert.ToInt32(Console.ReadLine());
                
                ar[i] = m;

            }
            
            return ar;
        }
    }
}
