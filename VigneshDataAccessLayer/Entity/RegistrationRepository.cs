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
        string connectionString = "server=DESKTOP-1U0BM0H\\SQLEXPRESS;database=Batch9;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
      

        public RegistrationRepository()
        {
            con = new SqlConnection(connectionString);
        }

        public List<Registration> SelectALLUser()
        {
            try
            {
                var selectQuery = $"select registrationid as Registrationid, username,password,email,mobileNumber,address from registration";
                con.Open();
                List<Registration> result = con.Query<Registration>(selectQuery).ToList();
                con.Close();

                return result;
            }
            catch(Exception ex)
            {
                throw; 
            }

        }
        public Registration SelectUserbyUserName(string username)
        {
            try
            {
               var selectQuery = $"select username,password,email,mobileNumber,address from registration where username ='{username}'";
                con.Open();
                Registration result = con.QueryFirstOrDefault<Registration>(selectQuery);
                con.Close();

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void RegisterUser(Registration reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber,Address) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber},'{reg.Address}')";
                con.Open();
                con.Execute(insertQuery);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void UpdateUser(Registration reg)
        {
            try
            {
                var updateQuery = $"update registration set username='{reg.UserName}',password='{reg.PassWord}',email='{reg.Email}', mobilenumber={reg.MobileNumber}, address='{reg.Address}' where registrationID={reg.RegistrationId}";
                con.Open();
                con.Execute(updateQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }


        }
        public void DeletUser(long regId)
        {
            try
            {
                var updateQuery = $"Delete from Registration where RegistrationID={regId}";
                con.Open();
                con.Execute(updateQuery);
                con.Close();


            }
            catch (Exception ex)
            {
                throw;
            }


        }
    }
}
