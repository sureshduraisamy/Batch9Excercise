using System;
using System.Collections.Generic;


namespace Polymorphism
{
    public class overridingconc
    {
        public virtual void Names()
        {
            string a = "i am naveen kumar ,i have completed my btech degree";
            Console.WriteLine(a);
        }
    }
    public class Nextstep : overridingconc
    {
        public override void Names()
        {
            string a = "i am magesh , i have not completed my btech degree";
            Console.WriteLine(a);
        }
    }
    public class Laststep : overridingconc

    {
        public void newname()
        {
            Names();
        }
    }
}
