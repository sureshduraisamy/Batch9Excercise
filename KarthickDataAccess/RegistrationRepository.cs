using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using KarthickDataAccess.Entity;
namespace KarthickDataAccess
{
   public class RegistrationRepository
    {
        string connectionString = "server=desktop-blbgehj\\sqlexpress;database=batch9;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public RegistrationRepository() {
            con = new SqlConnection(connectionString);
        }


        public void RegisterUser(Registration reg)
        {
            try
            {
               var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.userName}','{reg.password}','{reg.email}',{reg.mobileNumber})";
               // var connectionString = "server=desktop-blbgehj\\sqlexpress;database=batch9;user Id =sa;password=Anaiyaan@123;";
               // SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                con.Execute(insertQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteUserRecord(Registration reg)
        {
            try
            {
                var DeleteQuery = $"delete from registration where {reg.regsitrationId}";
                // var connectionString = "server=desktop-blbgehj\\sqlexpress;database=batch9;user Id =sa;password=Anaiyaan@123;";
                // SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                con.Execute(DeleteQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
