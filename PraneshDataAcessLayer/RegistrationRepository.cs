﻿using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using PraneshDataAcessLayer.Entity;

namespace PraneshDataAcessLayer
{
    public class RegisterPasswod
    {
        string connectionstring = "server=DESKTOP-BLBGEHJ\\SQLEXPRESS;DATAbase=batch9;user Id=sa;password=Anaiyaan@123";
        SqlConnection con = null;

        public RegisterPasswod()
        {
            con = new SqlConnection(connectionstring);
        }
        public List<Registration> selectAlluaer()
        {

            try
            {
                var selectQuery = $"select registration as Registration,username,pasword,email,mobialnumber,address from registration";
                con.Open();
                List<Registration> result = con.Query<Registration>(selectQuery).ToList();
                con.Close();
                return result;



            }
            catch (Exception EX)
            {
                throw;

            }
        }
           public  void Registeruser(Registration reg)
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

        public void RegisterUser(Registration userRegData)
        {
            throw new NotImplementedException();
        }

        public void UpdateuserData(Registration reg)
        {
            try
            {
                var UpdateQuery = $"update  Registration set  username ='{reg.UserName}',password ='{reg.PassWord}',email ='{reg.Email}',mobilenumber ={reg.MobileNumber} where registrationid = {reg.RegistrationId}";

                con.Open();
                con.Execute(UpdateQuery);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Deleteuser(Registration reg)
        {
            try
            {
                var UpdateQuery = $"delete from  Registration where registrationid = {reg.RegistrationId}";
                con.Open();
                con.Execute(UpdateQuery);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Registration> Selectalluser()
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

    }

}




