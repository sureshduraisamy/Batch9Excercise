using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
   public class Employee
    {
        public string Name;
        public int Age;
        public string Location;

    }

    public class ListExe
    {
        public List<Employee> Details()
        {
            try
            {
                Console.WriteLine("enter the count");
                int count = Convert.ToInt32(Console.ReadLine());
                List<Employee> data = new List<Employee>();
                for(int i = 0; i < count; i++)
                {
                    Employee source = new Employee();
                    Console.WriteLine("enter name");
                    source.Name = Console.ReadLine();
                    Console.WriteLine("enter age");
                    source.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter location");
                    source.Location = Console.ReadLine();
                    data.Add(source);
                }

                return data;
            }
            catch(Exception e)
            {
                throw;
            }
            
        }
    }
}
