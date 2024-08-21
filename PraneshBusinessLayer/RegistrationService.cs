
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraneshDataAcessLayer;
using PraneshDataAcessLayer.Entity;



namespace PraneshBusinessLayer
{
    public class RegistrationService
    {
        RegistrationRepository regRepObj = new RegistrationRepository();


        public void MenuOption()
        {
            int input = 0;
            do
            {
                Console.WriteLine("Please select any option below ");
                Console.WriteLine("1.Select ALL User");
                Console.WriteLine("2.Insert");
                Console.WriteLine("3.update");
                Console.WriteLine("4.delete");
                Console.WriteLine("5.exist");

                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        ShowAllUsersInformation();
                        break;
                    case 2:
                        GetUserRegistrationInformation();
                        break;
                    case 3:
                        GetUserUpdateInformation();
                        break;
                    case 4:
                        RemoveRecord();
                        break;
                }


            } while (input < 5);
        }

        public void ShowAllUsersInformation()
        {
            
            var users = regRepObj.Selectalluser();

            Console.WriteLine($"RegestrationID --Username--Password--Email--MobileNumber--Address");
            foreach (Registration reg in users)
            {
                Console.WriteLine($"{reg.regsitrationId } --{reg.userName}--{reg.password}--{reg.email}--{reg.mobileNumber}--{reg.address}");
            }

        }

        public void RemoveRecord()
        {
            try
            {
                RegistrationRepository regRepObj = new RegistrationRepository();
                var userRegData = new Registration();
                Console.WriteLine("Enter the registeration -- id --  to delete ");
                userRegData.regsitrationId = Convert.ToInt32(Console.ReadLine());
                regRepObj.Deleteuser(userRegData);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public void GetUserUpdateInformation()
        {
            try
            {
                Console.WriteLine("enter registeration Id");
                var RegisterationId = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("enter username");
                var username = Console.ReadLine();
                Console.WriteLine("enter password");
                var password = Console.ReadLine();
                Console.WriteLine("enter email");
                var email = Console.ReadLine();
                Console.WriteLine("enter mobile number");
                var mobileNumber = Convert.ToInt64(Console.ReadLine());

                var userRegData = new Registration();
                userRegData.userName = username;
                userRegData.password = password;
                userRegData.email = email;
                userRegData.mobileNumber = mobileNumber;
                userRegData.regsitrationId = RegisterationId;

                RegistrationRepository obj = new RegistrationRepository();
                obj.UpdateuserData(userRegData);

            }
            catch (Exception e)
            {
                throw;
            }
        }



        public void GetUserRegistrationInformation()
        {
            try
            {
                Console.WriteLine("enter username");
                var username = Console.ReadLine();
                Console.WriteLine("enter password");
                var password = Console.ReadLine();
                Console.WriteLine("enter email");
                var email = Console.ReadLine();
                Console.WriteLine("enter mobile number");
                var mobileNumber = Convert.ToInt64(Console.ReadLine());

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
