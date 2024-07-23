using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giridharan_BusinessLayer
{
    public class Childclass:Parentclass
    {
        public void Studentdetails()
        {
            Details();
            string qualification = "B.sc Information Technology";
            Console.WriteLine("Qualification:"+qualification);
        }

    }
}
