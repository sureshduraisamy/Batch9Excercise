using System;

namespace PraneshBusinessLayer
{
    public class VowelCount
    {
        public void print() 
        {
            string a = " i a pranesh";
            string vowel = "ranjith";
            int counter = 0;


            for(int i = 0; i < vowel.Length; i++) 
            {
            for(int j=0;j<a.Length; j++) 
                {
                if(a[j]==vowel[i]) 
                    {
                        counter++;
                    
                    }
                
                
                
                }

                Console.WriteLine(vowel[i] + "" + counter);
                counter = 0;
            }

            

            
                



        
        
        }



        



            


    }
}
