using System;


namespace Alphabetvowels
{
    class vowels
    {
        char words;
        public void vowelcheck()
            
        {
            Console.WriteLine("enter the alpahbet");
            words = (Convert.ToChar(Console.ReadLine()));
            if (words == 'a' || words == 'e' || words == 'i' || words == 'o' || words == 'u')
            {
                Console.WriteLine("its a vowel");
            }
            else
            {
                Console.WriteLine("its not a vowel");
            }



        }
    }
}
