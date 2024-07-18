using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveendevi.consol
{
   public static class college
    {
        static string collegename = "Akka University";
        static string Departnment = "MECH";
        static int year = 0;

        public static string CollegeMethod()
        {
            return collegename + Departnment + year;

        }
        static college()
        {
            year++;
        }


    }




    



    }

