using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class Course
    {
        public string Name;
        public int Duration
        {
            get;set;
        }
        public int Vaccancy
        {
            get;set;
        }
        public void Details()
        {
            Duration = 7;
            Name = "Giri";
            Vaccancy = 6;
            
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Duration:" + Duration);
            Console.WriteLine("Vaccancy:" + Vaccancy);
        }
    }
}
