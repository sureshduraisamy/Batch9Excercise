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
                var insertQuery = $"insert into Registration(UserName,Password,Email) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}')";
                var connectionString = "server=DESKTOP-BLBGEHJ\\SQLEXPRESS;database=Bach9;user Id =sa;password=Anaiyaan@123;TrustServerCertificate=True;";
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


