﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikramDataAccessLayer;
using VikramDataAccessLayer.Entity;

namespace VikramBusinessLayer
{
    public class RegistrationService
    {
      public  RegistrationRepository regRepObj =null;
        
        public RegistrationService()
        {
            regRepObj = new RegistrationRepository();
        }
        public void MenuDriven()
        {
            int input = 0;
            do
            {
                Console.WriteLine("Please select any option below");
                Console.WriteLine("1.SelectALLUser");
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
                        updatetUserRegistrationInformation();
                        break;
                    case 4:
                        RemoveRecord();
                        break;
                }


            } while (input < 5);

        }

        public void RemoveRecord()
        {
            try
            {
                RegistrationRepository regRepObj = new RegistrationRepository();
                var userRegData = new Registration();
                Console.WriteLine("Enter the registeration -- id --  to delete ");
                userRegData.RegsitrationId = Convert.ToInt32(Console.ReadLine());
                regRepObj.DeleteUser(userRegData);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void ShowAllUsersInformation()
        {
            var users = regRepObj.SelectAllUser();

            Console.WriteLine($"RegistrationID --Username--Password--Email--MobileNumber--Address");
            
            foreach (Registration reg in users)
            {
                Console.WriteLine($"{reg.RegsitrationId} --{reg.UserName}--{reg.PassWord}--{reg.Email}--{reg.MobileNumber}--{reg.Address}");
            }


        }
        public void updatetUserRegistrationInformation()
        {
            try
            {
                Console.WriteLine("enter registeration Id");
                var RegisterationId = Convert.ToInt64(Console.ReadLine());
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
                userRegData.RegsitrationId = RegisterationId;
                var obj = new RegistrationRepository();

                obj.Update(userRegData);

            }
            catch (Exception ex)
            {
                throw;

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

                var userRegData = new Registration();
                userRegData.UserName = username;
                userRegData.PassWord = password;
                userRegData.Email = email;
                userRegData.MobileNumber = mobileNumber;

                var obj = new RegistrationRepository();

                obj.RegisterUser(userRegData);

            }
            catch (Exception ex)
            {
                throw;

            }
        }
    }
}
