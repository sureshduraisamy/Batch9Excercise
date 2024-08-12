using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayerNaveen.Entity;

namespace DataAccessLayerNaveen
{
    public class RegistrationRepositorynk
    {
        public void Registeruser(Registrationnk reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber})";
                var connectionString = "server=DESKTOP-Q9V2K5P\\SQLEXPRESS;database=Batch 9;user Id =sa;password=Anaiyaan@123;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                con.Execute(insertQuery);
                con.Close();
            }
            catch(Exception ex)
            {
                throw;
            }

        }
    }
}
