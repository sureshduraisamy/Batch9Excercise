using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ConsoleApp
{
    class ReadData
    {
        string name;
        int age;
        
        public void GetData()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Age");
            int age =  Convert.ToInt16( Console.ReadLine());
            Console.WriteLine(age);
        }
        public void PrintData()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }


    }
}
