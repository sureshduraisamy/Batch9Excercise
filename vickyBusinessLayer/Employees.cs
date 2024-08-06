using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vickyBusinessLayer
{
    class Employees
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class EmployeeDetails
    {
        public void Details()
        {
            Employees[] D = new Employees[4];
            Employees A = new Employees();
            A.Name = "vicky";
            A.Age = 21;
            D[0] = A;
            Employees B = new Employees();
            B.Name = "vinoth";
            B.Age = 23;
            D[1] = B;
            Employees C = new Employees();
            C.Name = "siva";
            C.Age = 24;
            D[2] = C;

            List<Employees> Employeeslist = new List<Employees>();
            Employeeslist.Add(A);
            Employeeslist.Add(B);
            Employeeslist.Add(C);

            foreach(Employees Emp in Employeeslist)
            {
                Console.WriteLine("Name:"+Emp.Name);
                Console.WriteLine("Age:"+Emp.Age);
            }

        }
    }
}
