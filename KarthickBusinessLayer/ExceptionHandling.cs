using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarthickBusinessLayer
{
 public abstract  class ExceptionHandling
    {
        public ExceptionHandling()
        {
            Console.WriteLine("Constructor in base class");
        }
        public ExceptionHandling(int a)
        {
            Console.WriteLine("Constructor");
        }
       public abstract void Task();

        public virtual void M1()
        {
            Console.WriteLine("Virtual method in base class");
        }


    }

    //Inheriting abstract class in derived class
    public class UserRegisteration:ExceptionHandling
    {
        public override void M1()
        {
            base.M1();
            int[] a = new int[5];
            try
            {
                Console.WriteLine(a[6]);
            }
            catch (Exception e)
            {
                throw;
            }
            
        }
        public UserRegisteration(int b):base(b)
        {

        }

      public override   void Task()
        {
            Console.WriteLine("abstract method");
        }


    }


     

}
