using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class Constitution
    {
        int count;

        public Constitution()
        {
            count= Convert.ToInt32(Console.ReadLine());
            Candidates[] Arr = new Candidates[count];



            int i = 0;
            for ( i = 0; i < 10 ; i++) 
            {
                Candidates c  = new Candidates();
                c.Name = Console.ReadLine();
                c.constitution = Console.ReadLine();
                c .Age = Convert.ToInt32(Console.ReadLine());
                
                Arr[i] = c;
            }
            
            {
                Console.WriteLine(Arr[0].Name);
                Console.WriteLine(Arr[0].constitution);
                Console.WriteLine(Arr[0].Age);

            }






        }




    }
}
