using System;


namespace parameterandreturntype
{
    class Nonreturntype
    {
        public void Nonreturn()
        {
            int a = 10;
            int b = 10;
            int c = a + b;
            Console.WriteLine(c);

                
        }

    }

   
      class Returntype
    {
        public int Addition()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return (c);

        }
    }
    class Nonreturnpara
    {
        public void num(int a ,int b , int c)
        {
            Console.WriteLine(a+b+c);
        }
    }

    class returnpara
    {
        public int Add(int a,int b,int c)
        {
              
            return (a + b + c);
        }
    }

    class returnparaex
    {
        public string details(int age , string name, char gender)
        {
             
          return (age + name + gender);
        }
    }
           
}
