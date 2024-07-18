using System;
using System.Collections.Generic;


namespace Statictype
{
     class Staticclasstype
    {

        public  string name { get; set; }
        public static int count { get; set; }
    }
    public static class source
    {
        public static string Name = "naveeb";
        public static int age = 10;
        public static string location = "cbe";
        public static void details()
        {
            for(int i = 0; i < 3; i++)
            {
               Console.WriteLine(Name) ;
               Console.WriteLine(age) ;
               Console.WriteLine(location) ;

            }
        }
    }
    class A
    {
        public A()
        {
            int a = 10;
            Console.WriteLine(a);
        }
        public A(int b,int c)
        {
            int d = b + c;
            Console.WriteLine(d);
        }
         static A()
        {
            Console.WriteLine("hello");
        }

    }
}
