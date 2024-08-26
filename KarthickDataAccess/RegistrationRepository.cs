using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using KarthickDataAccess.Entity;
using Microsoft.Extensions.Configuration;

namespace KarthickDataAccess
{
   public class RegistrationRepository:IRegisterationRepository
    {
        string connectionString = "server=desktop-blbgehj\\sqlexpress;database=batch9;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public RegistrationRepository(IConfiguration configuration) {
            connectionString =  configuration.GetConnectionString("DbConnection");
            con = new SqlConnection(connectionString);
        }


        public void RegisterUser(Registration reg)
        {
            try
            {
               var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber,Address)" +
                    $" values ('{reg.userName}','{reg.password}','{reg.email}',{reg.mobileNumber},'{reg.address}')";
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

        public void UpdateUser(Registration reg)
        {
            try
            {
                var updateQuery = $"update registration set username='{reg.userName}',password='{reg.password}',email='{reg.email}', mobilenumber={reg.mobileNumber},Address='{reg.address}' where registrationID={reg.regsitrationId}";
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

        /*
          public List<Registration> SelectALLUser();
         public void UpdateUser(Registration reg);
         public void RegisterUser(Registration reg);
          public Registration SelectUserByUsername(string username);
          public void DeleteUserRecord(long regId);
         */


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
                var selectQuery = $"select registrationId as RegsitrationId,username,password,email,mobileNumber,address from registration where username ='{username}'";
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


        public void DeleteUserRecord(long regId)
        {
            try
            {
                var DeleteQuery = $"delete from registration where RegistrationID={regId}";
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
