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
                var selectQuery = $"select regestrationID as RegestrationId ,username,password,email,mobileNumber,address from Registration";
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
                var UpdateQuery = $"update  Registration set  username ='{reg.userName}',password ='{reg.password}',email ='{reg.email}',mobilenumber ={reg.mobileNumber} where RegestrationID = {reg.RegestrationID}";

                con.Open();
                con.Execute(UpdateQuery);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Deleteuser(long regId)
        {
            try
            {
                var UpdateQuery = $"delete from Registration where RegestrationID = {regId}";
                con.Open();
                con.Execute(UpdateQuery);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Deleteuser(Registration userRegData)
        {
            throw new NotImplementedException();
        }

        public Registration SelectByUsername(long RegestrationID)
        {
            try
            {
                var selectQuery = $"select RegestrationID, username,password,email,mobileNumber,address from Registration where RegestrationID = '{RegestrationID}'";
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

    }

}




