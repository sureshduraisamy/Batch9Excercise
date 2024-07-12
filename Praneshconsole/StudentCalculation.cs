using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praneshconsole
{
    class StudentCalculation
    {
        int count;
        
        public StudentCalculation()
        {
            count = Convert.ToInt32(Console.ReadLine());
            StudentMark[] studen = new StudentMark[count];

            for(int i=0;i<5; i++) 
             
          {
                StudentMark sm = new();
                sm.Name =Console .ReadLine ();
            
            
                
            int Tamil = Convert.ToInt32(Console.ReadLine());
            
            int English = Convert.ToInt32(Console.ReadLine());
            
            int Maths = Convert.ToInt32(Console.ReadLine());
            
            int Science = Convert.ToInt32(Console.ReadLine());
            
            int Socailscience = Convert.ToInt32(Console.ReadLine());

                studen[i] = sm;
                {
                    Console.WriteLine(studen[i].Name);
                    Console.WriteLine(studen[i].Tamil);
                    Console.WriteLine(studen[i].English);
                    Console.WriteLine(studen[i].Maths);
                    Console.WriteLine(studen[i].Science);
                    Console.WriteLine(studen[i].SocialScience);

                }
               
            }










        }














    }
}
