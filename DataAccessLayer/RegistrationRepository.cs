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
        string connectionString = "server=DESKTOP-8VD1A1F\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public RegistrationRepository()
        {
            con = new SqlConnection(connectionString);
        }

        public List<Registration> SelectALLUser()
        {
            try
            {
                var selectQuery = $"select registrationId as RegsitrationId, username,password,email,mobileNumber,address from registration";
                con.Open();
                List<Registration> result = con.Query<Registration>(selectQuery).ToList();
                con.Close();

                return result;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Registration SelectUserByUsername(string username)
        {
            try
            {
                var selectQuery = $"select username,RegistrationId,password,email,mobileNumber,address from registration where username ='{username}'";
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

        public void  RegisterUser(Registration reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(registrationId,UserName,Password,Email,MobileNumber,Address) values ('{reg.RegsitrationId}','{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber}',{reg.Address})";
                con.Open();
                con.Execute(insertQuery);
                con.Close();

            }catch(Exception ex)
            {
                throw;
            }
        }

        public void UpdateUser(Registration reg)
        {
            try
            {
                var updateQuery = $"update registration set username='{reg.UserName}',password='{reg.PassWord}',email='{reg.Email}', mobilenumber={reg.MobileNumber} where registrationID={reg.RegsitrationId}";
                //var connectionString = "server=DESKTOP-8VD1A1F\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
               
                con.Open();
                con.Execute(updateQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void DeleteUser(long  regId)
        {
            try
            {
                var updateQuery = $"Delete from Registration where regsitrationId={regId}";
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
