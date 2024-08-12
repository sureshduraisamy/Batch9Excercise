using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace VigneshDataAccessLayer.Entity
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
                var InsertQuery=$"insert into Registration(UserName,Password,Email,MoblieNumber) values('{reg.UserName}','{reg.PassWord},'{reg.Email},{reg.MobileNumber})";
                var ConnectionString = "server=DESKTOP-1U0BM0H\\SQLEXPRESS;database=Batch9;user Id =sa;password=Anaiyaan@123;";

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                con.Execute(InsertQuery);
                con.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

       
    }
}
