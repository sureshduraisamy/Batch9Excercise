using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraneshBusinessLayer
{

    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class EmployeeDetails
    {
        public void Details()
        {
            Employee[] D = new Employee[3];
            Employee A = new Employee();
            A.Name = "pranesh"; A.Age = 23;
            D[0] = A;
            Employee B = new Employee();
            B.Name = "Giri"; B.Age = 24;
            D[1] = B;
            List<Employee> EmployeesList = new List<Employee>();
            EmployeesList.Add(A);
            EmployeesList.Add(B);
            foreach (Employee Emp in EmployeesList)
               
            
            {
                Console.WriteLine("Name:" + Emp.Name);
                Console.WriteLine("Age:" + Emp.Age);
            }
        }
    }
}

                   