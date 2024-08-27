using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer
{


    public interface IRegistrationRepository
    {
        public List<Registration> SelectALLUser();
        public Registration SelectUserByUsername(string username);
        public void RegisterUser(Registration reg);
        public void UpdateUser(Registration reg);
        public void DeleteUser(long regId);

    }


    public class RegistrationRepository: IRegistrationRepository
    {
        string connectionString = string.Empty; //"server=DESKTOP-8VD1A1F\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public RegistrationRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DbConnection");
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

        public void  RegisterUser(Registration reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber})";
                var connectionString = "server=DESKTOP-1U0BM0H\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
                SqlConnection con = new SqlConnection(connectionString);
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
