using System;
using Dapper;
using Microsoft.Data.SqlClient;
using PraneshDataAcessLayer.Entity;

namespace PraneshDataAcessLayer {
    public class RegistrationRepository
    {
        public RegistrationRepository()
        {

        }

        public void RegisterUser(Registration reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber})";
                var connectionString = "server=DESKTOP-8VD1A1F\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                con.Execute(insertQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}


