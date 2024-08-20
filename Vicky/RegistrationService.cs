using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigneshDataAccessLayer.Entity;
using VigneshDataAccessLayer;

namespace Vicky
{
    public class RegistrationService
    {
            RegistrationRepository regRepObj = null;
            public RegistrationService()
            {
                regRepObj = new RegistrationRepository();
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
                        ShowAllUsersInformation();
                            break;
                        case 2:
                            GetUserRegistrationInformation();
                            break;
                        case 3:
                        GetUserRegistrationInformation();
                        break;
                    case 4:
                        GetUserRegistrationInformation();
                        break;
                    case 5:
                        GetUserRegistrationInformation();
                        break;

                }


                } while (input !=5);

            }



            public void ShowAllUsersInformation()
            {


                var users = regRepObj.SelectALLUser();

                Console.WriteLine($"RegistrationID --Username--Password--Email--MobileNumber--Address");
                foreach (Registration reg in users)
                {
                    Console.WriteLine($"{reg.RegsitrationId} --{reg.UserName}--{reg.PassWord}--{reg.Email}--{reg.MobileNumber}--{reg.Address}");
                }

            }

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

                    var userRegData = new DataAccessLayer.Entity.Registration();
                    userRegData.UserName = username;
                    userRegData.PassWord = password;
                    userRegData.Email = email;
                    userRegData.MobileNumber = mobileNumber;

                    var obj = new DataAccessLayer.RegistrationRepository();

                    obj.RegisterUser(userRegData);
                }
                catch (Exception ex)
                {
                    throw;
                }


            }
        
    }
}