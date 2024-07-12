using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class CandidateDetails
    {
       public int count;
        public Candidate[] EnterDetails(Candidate D)
        {
           count=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(D.name);
            Candidate[] arr= new Candidate[count];
            for (int i=0;i<count;i++)
            {
                Candidate Dm = new();
                Dm.name = Console.ReadLine();
                Dm.ConstitutionName = Console.ReadLine();
                Dm.age = Convert.ToInt32(Console.ReadLine());
               
                arr[i] = Dm;
            }
          
           
            return arr;
        }
    }
}
