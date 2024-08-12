
using Dapper;
using GiridharanDataAcessLayer.Entity;
using System;
using System.Data.SqlClient;

namespace GiridharanDataAcessLayer
{
    public class RegistrationRepository
    {
        public RegistrationRepository()
        {

        }
        public void RegisterUser(Registration reg)
        {
            try
            {


                var insertQuery = $"Insert into Registration(Username,Password,Email,MobileNumber) values ('{reg.Username}','{ reg.Password}','{reg.Email}',{reg.MobileNumber})";
                var ConnectionString = "server=DESKTOP-UCPA9BN;database=Batch9;user Id=sa;password=Anaiyaan@123;";
                SqlConnection con = new SqlConnection(ConnectionString);
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
