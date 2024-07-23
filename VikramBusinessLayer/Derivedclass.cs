using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikramBusinessLayer
{
   public class Derivedclass:Baseclass
    {
        public void StudentDetails()
        {
            Details();
            string qualification="B.sc Mathematics";
            Console.WriteLine("Qualification:" + qualification);
        }

    }
}
