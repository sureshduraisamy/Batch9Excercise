using System;
using System.Collections.Generic;


namespace Extension
{
    public static class ExtensionMethod
    {
        public static bool IsValidPhoneno(this string Mobile)
        {
            bool check = false;
            if (Mobile.Length == 10) 
            {
                for (int i = 0; i < 10; i++)
                {
                    if ((Mobile[i] == '0' )||( Mobile[i] == '1') ||( Mobile[i] == '2') || (Mobile[i] == '3') ||( Mobile[i] == '4' )||( Mobile[i] == '5' )|| (Mobile[i] == '6' )|| (Mobile[i] == '7') || (Mobile[i] == '8') || (Mobile[i] == '9'))
                    {

                        check = true;
                    }

                    else
                    {
                        check = false;
                        break;
                    }

                }
            }
            return check;
        }
    }
}
