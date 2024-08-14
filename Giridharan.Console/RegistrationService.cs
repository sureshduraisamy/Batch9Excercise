using GiridharanDataAcessLayer;
using System;
using GiridharanDataAcessLayer.Entity;

namespace GiridharanConsole
{
    class RegistrationService
    {
        RegistrationRepository regRepobj = null;
        public RegistrationService()
        {
            regRepobj = new RegistrationRepository();
        }
        public void MenuDriven()
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
                        ShowAllUserInformation();
                        break;
                    case 2:
                        GetUserRegistrationInformation();
                        break;
                    case 3:
                        GetUserUpdateInformation();
                        break;
                    case 4:
                        GetUserDeleteInformation();
                        break;
                }

            } while (input > 5);
        }
        public void GetUserDeleteInformation()
        {
            try
            {
                var userRegData = new Registration();
                Console.WriteLine("Enter the Registration--ID--to delete:");
                userRegData.RegistrationID = Convert.ToInt64(Console.ReadLine());
                regRepobj.DeleteUser(userRegData);
            }catch(Exception ex)
            {
                throw;
            }
        }
        public void GetUserUpdateInformation()
        {
            try
            {
                Console.WriteLine("Enter RegistrationID:");
                var registrationId = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Username");
                var username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                var password = Console.ReadLine();
                Console.WriteLine("Enter Email");
                var email = Console.ReadLine();
                Console.WriteLine("Enter Mobile");
                var mobileNumber = Convert.ToInt64(Console.ReadLine());


                var userRegData = new Registration();

                userRegData.RegistrationID = registrationId;
                userRegData.Username = username;
                userRegData.Password = password;
                userRegData.Email = email;
                userRegData.MobileNumber = mobileNumber;


                regRepobj.UpdateUser(userRegData);

            }
            catch (Exception ex)
            {
                throw;

            }
        }
        public void ShowAllUserInformation()
        {
            try
            {
                var users = regRepobj.SelectAllUser();
                Console.WriteLine($"RegistrationID --Username--Password--Email--MobileNumber--Address");
                foreach (Registration reg in users)
                {
                    Console.WriteLine($"{reg.RegistrationID}--{reg.Username}--{reg.Password}--{reg.Email}--{reg.Adress}");
                }
            }catch(Exception ex)
            {
                throw;
            }
           
        }
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

                
                regRepobj.RegisterUser(userRegData);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
