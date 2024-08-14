using System;
using Dapper;
using VikramDataAccessLayer;
using System.Data.SqlClient;
using VikramDataAccessLayer.Entity;
using System.Collections.Generic;
using System.Linq;

namespace VikramDataAccessLayer
{
    public class RegistrationRepository
    {
        string connectionstring = "server=DESKTOP-BLBGEHJ\\SQLEXPRESS;database=batch9;user Id=sa;password=Anaiyaan@123;";
        SqlConnection con = null;


        public RegistrationRepository()
        {
            con = new SqlConnection(connectionstring);
        }
        public List<Registration> SelectAllUser()
        {
            try
            {
                var selectQuery = $"select registrationId as RegistrationId,username,password,email,mobileNumber,address from registration";
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



        public void RegisterUser(Registration reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber})";
                var connectionString = "server=DESKTOP-BLBGEHJ\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
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

        public void DeleteUser(Registration regId)
        {
            try
            {
                
                var updateQuery = $"Delete from registration where registrationId={regId.RegsitrationId}";
                con.Open();
                con.Execute(updateQuery);
                con.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void Update(Registration reg)
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


        public void DeleteUser(long regId)
            {
                try
                {
                    var updateQuery = $"Delete from Registration where registrationId={regId}";
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



    