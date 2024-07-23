using System;
using System.Collections.Generic;



namespace OOPSCONCEPT
{
    public class OOPS
    {
       public int a = 10;
       public int b = 20;
        
        public void Singleinheri()
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }

 
    public class Nextoops : OOPS
    {
       public int d = 40;
       public int h = 40;
        public void inheriting()
        {
            Console.WriteLine(a + b);
            Singleinheri();

        }
    }
    public class Multilevel : Nextoops
    {  public void multileveling()
        {
            int f = d + h;
            Console.WriteLine(f);
            inheriting();
        }
    }
}
