using System;
using System.Collections.Generic;
using Extension;


namespace Extensiontest
{
    class TestExtension
    {
        public void Testing()
        {
            string mobileno = "8610026900";
            bool checking = mobileno.IsValidPhoneno();
            Console.WriteLine(checking);
        }
    }
}
