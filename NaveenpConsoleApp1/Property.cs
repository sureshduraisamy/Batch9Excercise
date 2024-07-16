using System;
using System.Collections.Generic;


namespace Propertycheck
{
    class Property
    {
        public string DoctorName { get; set; }
        public string Qualification { get; set; }
        public int Docage { get; set; }



    }

    class Hospitaldetails
    {
        public Property[] Details(string[] names)
        {
            Property[] datas = new Property[names.Length];
            for(int i = 0; i < names.Length; i++)
            {
                Property sm = new Property();
                Console.WriteLine("type doc name");
                sm.DoctorName = names[i];
                Console.WriteLine("type doc qua");
                sm.Qualification = Console.ReadLine();
                Console.WriteLine("type doc age");
                sm.Docage = Convert.ToInt32(Console.ReadLine());
                datas[i] = sm;

            }
            return datas;

        }
    }
}
