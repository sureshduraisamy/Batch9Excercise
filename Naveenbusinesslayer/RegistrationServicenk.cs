using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerNaveen;
using DataAccessLayerNaveen.Entity;
using DataAccessLayerNaveen;


namespace Naveenbusinesslayer
{
   public  class RegistrationServicenk
    {
        public void GetUserInfo()
        {
            try
            {
                Console.WriteLine("enter Name");
                var username = Console.ReadLine();
                Console.WriteLine("enter password");
                var password = Console.ReadLine();
                Console.WriteLine("enter mobileno");
                var mobileno = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("enter email");
                var Email = Console.ReadLine();

                var userinput = new Registrationnk();
                userinput.UserName = username;
                userinput.PassWord = password;
                userinput.MobileNumber = mobileno;
                userinput.Email = Email;

                var obj = new RegistrationRepositorynk();
                obj.Registeruser(userinput);
            }
            catch(Exception ex)
            {
                throw ;
            }
            
        }
    }
}
