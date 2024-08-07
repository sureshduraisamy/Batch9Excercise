using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PraneshBusinessLayer
{
   public  class ReadeWrite
    {

       public void reading()
        {
            string data;
            StreamReader Reader = null;
            StreamWriter writer = null;
            try 
            {
               Reader = new StreamReader("C:\\Users\\Admin\\Desktop\\model.txt");
                
                data = Reader.ReadLine();
                
                while (data !=null) 
                {
                    Console.WriteLine(data);
                    data = Reader.ReadLine();
                        

                }


            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            
            }
           
            
        
        
        
        
        }





    }
}
