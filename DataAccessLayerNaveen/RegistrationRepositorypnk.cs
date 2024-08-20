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
                var insertQuery = $"insert into Registration(UserName,Password,Email,MobileNumber,address) values ('{reg.UserName}','{reg.PassWord}','{reg.Email}',{reg.MobileNumber},'{reg.Address}')";

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
                var UpdateQuery = $"update  Registration set  username ='{reg.UserName}',password ='{reg.PassWord}',email ='{reg.Email}',mobilenumber ={reg.MobileNumber},address = '{reg.Address}' where registrationid = {reg.RegistrationId}";

                con.Open();
                con.Execute(UpdateQuery);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

       

        public void deleteuser(long reg)
        {
            try
            {
                var deleteQuery = $"delete from  Registration where registrationid = {reg}";
                con.Open();
                con.Execute(deleteQuery);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void deleteuser(string username)
        {
            throw new NotImplementedException();
        }

        public List<Registrationnk> selectalluser()
        {
            try
            {
                var selectQuery = $"select RegistrationId, username,password,email,mobileNumber,address from registration";
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
        public Registrationnk selectuserbyname(string username)
        {
            try
            {
                var selectQuery = $"select  username,password,email,mobileNumber,address,registrationid from registration where username = '{username}'";
                con.Open();
                Registrationnk result = con.QueryFirstOrDefault<Registrationnk>(selectQuery);
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

