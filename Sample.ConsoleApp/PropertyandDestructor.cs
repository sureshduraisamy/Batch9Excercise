using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ConsoleApp
{
    class Student
    {
        //variable
        public int Age
        { get; set; }

        public string Name
        {
            get
            {
                string b = "hai";
                return b;
            }
            set {

                if(value!= null)
                  Age = Convert.ToInt32(value);
            }
        }

    }


    partial class PropertyandDestructor
    {
        //default constructor
        public PropertyandDestructor()
        {

        }

        public PropertyandDestructor(int a)
        {

        }

        public PropertyandDestructor(Student a)
        {

        }

        public Student[] PopulateValues()
        {
            var numbers = new int[2];
            var students = new Student[2];
            students[0] = null;
            students[1] = null;
            numbers[0] = 0;
            numbers[1] = 0;
          

            for (int i=0; i<2;i++)
            {
                var s = new Student();
                s.Name = "Student-" + i;
                s.Age = 40 + i;
                students[i] = s;
            }

            return students;
        }

        ~PropertyandDestructor()
        {

        }

    }
}
