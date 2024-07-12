using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarman.console
{
    class CandidateDetails
    { 
       public int count;
    public Candidate[] Detail(Candidate k)
        {
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(k.name);
            Candidate[] arr = new Candidate[count];
            for(int i = 0; i < count; i++)
            {
                Candidate Dm = new Candidate();
                Console.WriteLine("enter the candidate name");
                Dm.name = Console.ReadLine();
                Console.WriteLine("enter the candidate constitution");
                Dm.constitution = Console.ReadLine();
                Console.WriteLine("enter the age");
                Dm.age = Convert.ToInt32(Console.ReadLine());
                k = Dm;
                arr[i] = Dm;

                
            }

            return arr;
        }
    }
}
