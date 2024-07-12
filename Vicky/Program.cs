using System;

namespace Vicky
{
    class Program
    {
        static void Main(string[] args)
        {

            Canditate obj = new Canditate();
            obj.name = Console.ReadLine();

            
            Constitution s = new Constitution();
            Canditate[] c = s.Enterdetails(obj);

       

            for (int i = 0; i < s.count; i++)
            {
                Console.WriteLine(c[i].name);
                Console.WriteLine(c[i].constitution);
                Console.WriteLine(c[i].age);
            }







            //Array obj = new Array();

                //EvenOrOdd obj = new EvenOrOdd();




                //Vowel obj = new Vowel();
                //obj.VowelFinder();







                //ParameterandReturntype obj = new ParameterandReturntype();
                //obj.method1();
                //obj.method2(45, 55, 65);
                //Console.WriteLine(obj.method3());





                // studentgrade obj = new();
                // obj.totalmark();


                // Bignumber obj = new();
                //obj.large();
                //obj.big();
        }
    }
}
