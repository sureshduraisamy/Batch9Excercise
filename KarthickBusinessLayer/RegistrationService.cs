using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarthickDataAccess;
using KarthickDataAccess.Entity;

namespace KarthickBusinessLayer
{
  public  class RegistrationService
    {

        public void GetUserRegistrationInformation()
        {
            try
            {
                Console.WriteLine("enter username");
                var username = Console.ReadLine();
                Console.WriteLine("enter password");
                var password = Console.ReadLine();
                Console.WriteLine("enter email");
                var email=Console.ReadLine();
                Console.WriteLine("enter mobile number");
                var mobileNumber=Convert.ToInt64(Console.ReadLine());

                var userRegData = new Registration();
                userRegData.userName = username;
                userRegData.password = password;
                userRegData.email = email;
                userRegData.mobileNumber = mobileNumber;

                RegistrationRepository obj = new RegistrationRepository();
                obj.RegisterUser(userRegData);

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
