
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace DataAccessLayer
{
    public class RegistrationRepository
    {
        public RegistrationRepository()
        {

        }

        public void  RegisterUser(Registration reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber})";
                var connectionString = "server=DESKTOP-8VD1A1F\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                con.Execute(insertQuery);
                con.Close();

            }catch(Exception ex)
            {
                throw;
            }
        }

        public object selectalluser()
        {
            throw new NotImplementedException();
        }

        public void deleteuser(global::PraneshDataAcessLayer.Entity.Registration userinput)
        {
            throw new NotImplementedException();
        }

        public void Registeruser(global::PraneshDataAcessLayer.Entity.Registration userinput)
        {
            throw new NotImplementedException();
        }

        public void Updateuser(global::PraneshDataAcessLayer.Entity.Registration userinput)
        {
            throw new NotImplementedException();
        }
    }
}
