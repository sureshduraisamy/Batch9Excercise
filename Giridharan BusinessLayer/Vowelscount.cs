using System;

namespace Giridharan_BusinessLayer
{
    public class Vowelscount
    {
        public void Vowels()
        {
            Console.WriteLine("Enter your String:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter your count characters:");
            string b = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < b.Length; i++)
            {
                for(int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                    {
                        count++;
                    }

                }
                Console.WriteLine(b[i] + "" + count);
                count = 0;
            }
        }
        


     }  
}

