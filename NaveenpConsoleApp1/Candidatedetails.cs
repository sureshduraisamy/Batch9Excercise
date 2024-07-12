using System;
using System.Collections.Generic;



namespace Electioncandidate
{
   
    class Detailelection
    {
        public string name;
        public string constitution;
        public int age;

    }
    class Detailfetch 
    {
        

        public int count;
        public Detailelection[] Details()
        {
            Console.WriteLine("enter the no.of candidate details to be fetched");
            count = Convert.ToInt32(Console.ReadLine());
            Detailelection[] data = new Detailelection[count];
            for (int i = 0; i < count; i++)
            {
                Detailelection func = new Detailelection();
                Console.WriteLine("enter candidate name");
                func.name = Console.ReadLine();
                Console.WriteLine("enter candidate constitution");
                func.constitution = Console.ReadLine();
                Console.WriteLine("enter candidate age");
                func.age = Convert.ToInt32(Console.ReadLine());
                data[i] = func;
            }
            

            return data;



        }

    }
}
