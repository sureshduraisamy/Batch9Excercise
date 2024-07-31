using System;
using System.Collections.Generic;


namespace Giridharan_BusinessLayer
{
    public class Employees
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class EmployeesDetails
    {
        public void Details()
        {
            Employees[] D = new Employees[3];
            Employees A = new Employees();
            A.Name = "Giri";
            A.Age = 23;
            D[0] = A;
            Employees B = new Employees();
            B.Name = "vickram";
            B.Age = 24;
            D[1] = B;
            Employees C = new Employees();
            C.Name = "Hari";
            C.Age = 25;
            D[2] = C;

            List<Employees> EmployeesList = new List<Employees>();
            EmployeesList.Add(A);
            EmployeesList.Add(B);
            EmployeesList.Add(C);
            
            foreach(Employees Emp in EmployeesList)
            {
                Console.WriteLine("Name"+Emp.Name);
                Console.WriteLine("Age:"+Emp.Age) ;
            }
        }
    }
}
