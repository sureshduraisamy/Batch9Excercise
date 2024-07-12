using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagudeesConsoleApp
{
    class Constitution
    {
       public int count = 0;
        
           public  Candidates[] EnterDetails(Candidates D)
           {
            Console.WriteLine(D.Name);

            count = Convert.ToInt32(Console.ReadLine());
            Candidates[] arr = new Candidates[count];
            
               for (int i=0; i<count; i++)
               {
                Candidates c = new();
                c.Name = Console.ReadLine();
                c.Constitution = Console.ReadLine();
                c.Age = Convert.ToInt32(Console.ReadLine());


                arr[i] = c;

               }

             
            return arr;
            
          











           }








        



















    }
}
