using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Entity;
using DataAcessLayer;

namespace BusinessLayer
{
    public class RegistrationService
    {



        public void GetUserRegistrationInformation()
        {
            try
            {

                Console.WriteLine("Enter Username");
                var username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                var password = Console.ReadLine();
                Console.WriteLine("Enter Email");
                var email = Console.ReadLine();
                Console.WriteLine("Enter Mobile");
                var mobileNumber = Convert.ToInt64(Console.ReadLine());

                var userRegData = new Registration();
                userRegData.UserName = username;
                userRegData.PassWord = password;
                userRegData.Email = email;
                userRegData.MobileNumber = mobileNumber;

                var obj = new RegistrationRepository();

                obj.RegisterUser(userRegData);

            }catch(Exception ex)
            {
                throw;

            }
        }
    }
}
