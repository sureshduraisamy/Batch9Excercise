using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiridharanConsole
{
    class StudentMarklist
    {
       public string name = "x";
        int tamil = 80;
        int english = 70;
        int maths;
        public void Report()
        {
            name = "Giridharan";
             maths = tamil;
            tamil = english;
            english = maths;
            Console.WriteLine(name);
            Console.WriteLine(tamil);
            Console.WriteLine(english);
        }
    }
}
