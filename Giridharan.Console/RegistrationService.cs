using GiridharanDataAcessLayer;
using System;
using GiridharanDataAcessLayer.Entity;

namespace GiridharanConsole
{
    class RegistrationService
    {
       public void GetUserRegistrationInformation()
        {

            try
            {



                Console.WriteLine("Enter UserName:");
                var username = Console.ReadLine();
                Console.WriteLine("Enter Password:");
                var password = Console.ReadLine();
                Console.WriteLine("Enter Email:");
                var email = Console.ReadLine();
                Console.WriteLine("Enter MobileNumber:");
                var mobilenumber = Convert.ToInt64(Console.ReadLine());

                var userRegData = new Registration();
                userRegData.Username = username;
                userRegData.Password = password;
                userRegData.Email = email;
                userRegData.MobileNumber = mobilenumber;

                var obj = new RegistrationRepository();
                obj.RegisterUser(userRegData);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
