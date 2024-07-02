using System;


namespace Typeconverting
{
    class Typoconvert
    {
        //implicit conversion
        public void Implicit()
        {
            int a = 100;
            Console.WriteLine(a.GetType());
            long b = a;
            Console.WriteLine(b.GetType());
        }

        public void Lowerhigher()
        {
            char a = 'A';
            short b = (short)(a);
            Console.WriteLine(b);
        }
        public void Higherlower()
        {
            short A = 100;
            char B = Convert.ToChar(A);
            Console.WriteLine(B);
        }


    }
}
