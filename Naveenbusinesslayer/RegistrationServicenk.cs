using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerNaveen;
using DataAccessLayerNaveen.Entity;



namespace Naveenbusinesslayer
{
    public class RegistrationServicenk
    {
        RegistrationRepositorynk Obj = null;
    
        public RegistrationServicenk()
        {
            Obj = new RegistrationRepositorynk();
            
        }

        public void Menudrive()
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
                        ShowAllUser();
                        break;
                    case 2:
                        GetUserInfo();
                        break;
                    case 3:
                        UpdateUserInfo();
                        break;
                    case 4:
                        Removerecord();
                        break;
                }
            } while (input < 5);
            





        }
        

        public void ShowAllUser()
        {
            var users = Obj.selectalluser();
            Console.WriteLine($"RegistrationID --Username--Password--Email--MobileNumber--Address");
            foreach (Registrationnk regs in users)
            {
                Console.WriteLine($"{regs.RegistrationId } --{regs.UserName}--{regs.PassWord}--{regs.Email}--{regs.MobileNumber}--{regs.Address}");
            }

        }

            public void Removerecord()
            {
                try
                {
                    var userinput = new Registrationnk();
                    Console.WriteLine("enter registration id to delete ");
                    userinput.RegistrationId = Convert.ToInt32(Console.ReadLine());
                    Obj.deleteuser(userinput);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            public void UpdateUserInfo()
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
                    Console.WriteLine("enter RegistrationId");
                    var registrationId = Convert.ToInt32(Console.ReadLine());



                    var userinput = new Registrationnk();
                    userinput.UserName = username;
                    userinput.PassWord = password;
                    userinput.MobileNumber = mobileno;
                    userinput.Email = Email;
                    userinput.RegistrationId = registrationId;


                    
                    Obj.Updateuser(userinput);


                }
                catch (Exception ex)
                {
                    throw;
                }

            }


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
               

                
                Obj.Registeruser(userinput);
               

                
            }
            catch(Exception ex)
            {
                throw ;
            }
            
        }
    }
}
