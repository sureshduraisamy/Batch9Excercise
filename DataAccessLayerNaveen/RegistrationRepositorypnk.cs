using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayerNaveen.Entity;

namespace DataAccessLayerNaveen
{
    public class RegistrationRepositorynk

    {
        string connectionString = "server=DESKTOP-Q9V2K5P\\SQLEXPRESS;database=Batch 9;user Id =sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public RegistrationRepositorynk()
        {
            con = new SqlConnection(connectionString);
        }
        public void Registeruser(Registrationnk reg)
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
        public void Updateuser(Registrationnk reg)
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
        public void deleteuser(Registrationnk reg)
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
        public List<Registrationnk> selectalluser()
        {
            try
            {
                var selectQuery = $"select registrationId as RegsitrationId, username,password,email,mobileNumber,address from registration";
                con.Open();
                List<Registrationnk> result = con.Query<Registrationnk>(selectQuery).ToList();
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

