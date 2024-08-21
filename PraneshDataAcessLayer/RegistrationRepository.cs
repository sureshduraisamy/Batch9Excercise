using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using PraneshDataAcessLayer.Entity;

namespace PraneshDataAcessLayer
{
    public class RegistrationRepository
    {
        string connectionstring = "server=DESKTOP-BLBGEHJ\\SQLEXPRESS;database=batch9;user Id=sa;password=Anaiyaan@123;TrustServerCertificate=True;";
        SqlConnection con = null;

        public RegistrationRepository()
        {
            con = new SqlConnection(connectionstring);
        }
        public List<Registration> selectAlluaer()
        {

            try
            {
                var selectQuery = $"select RegestrationID as regsitrationId ,username,pasword,email,mobialnumber,address from registration";
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
                    var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber) values ('{reg.userName}','{reg.password}','{reg.email}',{reg.mobileNumber})";

                    con.Open();
                    con.Execute(insertQuery);
                    con.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }



            }


        public void UpdateuserData(Registration reg)
        {
            try
            {
                var UpdateQuery = $"update  Registration set  username ='{reg.userName}',password ='{reg.password}',email ='{reg.email}',mobilenumber ={reg.mobileNumber} where RegestrationID = {reg.regsitrationId}";

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
                var UpdateQuery = $"delete from Registration where RegestrationID = {reg.regsitrationId}";
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
                var selectQuery = $"select RegestrationID as regsitrationId, username,password,email,mobileNumber,address from registration";
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




