﻿using System;

namespace Kavi.console
{
    class Studentmarksheet
    {

        public void CalculateTotal()
        {
            string studentName = "Pranesh"
            int english = 80;
            int tamil = 90;
            int maths = 70;
            int science = 97;
            int total = english + tamil + maths + science;
            Console.WriteLine(total);
            Console.WriteLine(studentName);
        }
    }
}