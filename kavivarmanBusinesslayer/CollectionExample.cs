using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kavivarmanBusinesslayer
{
    public class Collectionexample
    {

        public void GenericCollection()
        {
            List<int> value = new List<int>();

            try
            {
                value.Add(55);
                value.Add(70);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            foreach (int a in value)
            {
                Console.WriteLine(a);
            }
        }

        public void NonGenericCollection()
        {

            ArrayList values = new ArrayList();
            try
            {
                values.Add(700);
                values.Add("Hai");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            foreach (var a in values)
            {
                if (a is int)
                {
                    Console.WriteLine(a);
                }
                else if (a is string)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}