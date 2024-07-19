using System;

namespace KarthickBusinessLayer
{
    public class IndividuallVowel
    {
        public void print()
        {
            string a = "i am rohit";
            string vowel = "aeiou";
            int counter=0;

            for (int i=0;i<vowel.Length;i++)
            {
                for (int j=0;j<a.Length; j++)
                {
                    if (a[j]==vowel[i])
                    {
                        counter++;
                    }
                   
                }
                Console.WriteLine(vowel[i] + " " + counter);
                counter = 0;
            }
           // Console.WriteLine(counter);
        }
    }
}
