using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
    


        public class Employee
        {
            public string Name
            {
                set; get;
            }
            public int Id
            {
                set; get;
            }
            public double salary
            {
                set; get;
            }
        }
        public class Collection
        {
            public void EmployeeList()
            {
                Console.WriteLine("Enter the Count");
                int count = Convert.ToInt32(Console.ReadLine());
                List<Employee> val = new List<Employee>();
                for (int i = 0; i < count; i++)
                {
                    Employee obj = new Employee();
                    Console.WriteLine("Enter Name:");
                    obj.Name = Console.ReadLine();
                    Console.WriteLine("Enter Id:");
                    obj.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter salary:");
                    obj.salary = Convert.ToDouble(Console.ReadLine());
                    val.Add(obj);
                }
                foreach (Employee value in val)
                {
                    Console.WriteLine($"Name:{value.Name}");
                    Console.WriteLine($"Id:{value.Id}");
                    Console.WriteLine($"Salary:{value.salary}");
                }

            }
            public void GenericCollection()
            {
                List<int> val = new List<int>();
                try
                {

                    val.Add(99);
                    Console.WriteLine(val[0]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                foreach (int i in val)
                {
                    Console.WriteLine(i);
                }
            }
            public void NonGenericCollection()
            {

            }
        }
    }

