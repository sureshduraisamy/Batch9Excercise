﻿using DataAccesslayerkavi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccesslayerkavi
{
    public class RegistrationRepository
    {
        string connectionString = string.Empty; // "server=DESKTOP-DDKSO40\\SQLEXPRESS;database=batch9;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public RegistrationRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Dbconnectiov");
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

        public void RegisterUser(Registration reg)
        {
            try
            {
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber})";
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
                var updateQuery = $"update registration set username='{reg.UserName}',password='{reg.PassWord}',email='{reg.Email}', mobilenumber={reg.MobileNumber},Address='{reg.Address}' where registrationID={reg.RegsitrationId}";
           

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
                var updateQuery = $"Delete from Registration where registrationID={regId}";
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
