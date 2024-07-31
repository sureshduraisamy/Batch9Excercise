using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class ExceptionHandling
    {
        static ExceptionHandling()
        {
            Console.WriteLine("Static");
        }

        public ExceptionHandling()
        {
            Console.WriteLine("default");
        }

        public ExceptionHandling(int a,string s)
        {
            Console.WriteLine(a);
        }

        public abstract void M1();
        

        protected virtual void SendEMail()
        {
            //
        }

        internal void M3()
        {

        }

        protected internal void M4()
        {

        }
    }

}
