
using Dapper;
using GiridharanDataAcessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace GiridharanDataAcessLayer
{
    public class RegistrationRepository
    {
        string ConnectionString = "server=DESKTOP-UCPA9BN;database=Batch9;user Id=sa;password=Anaiyaan@123;";
        SqlConnection con = null;
        public RegistrationRepository()
        {
             con = new SqlConnection(ConnectionString);
        }
        public List<Registration>  SelectAllUser()
        {
            try
            {


                var selectQuery = $"select RegistrationID, Username,Password,Email,MobileNumber,Adress from registration";
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
        public Registration SelectUserByUserName(string Username)
        {
            try
            {

                
                var selectQuery = $"select RegistrationID,Username,Password,Email,MobileNumber,Adress from registration where Username='{Username}'";
                con.Open();
                Registration userresult = con.QueryFirstOrDefault<Registration>(selectQuery);
                con.Close();

                return userresult;

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


                        var insertQuery = $"Insert into Registration(Username,Password,Email,MobileNumber,Adress) values ('{reg.Username}','{ reg.Password}','{reg.Email}',{reg.MobileNumber},'{reg.Adress}')";
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


                        var updateQuery = $"update registration set Username='{reg.Username}',Password='{reg.Password}',Email='{reg.Email}',mobilenumber={reg.MobileNumber},Adress='{reg.Adress}' Where registrationId={reg.RegistrationID}";
                        // var ConnectionString = "server=DESKTOP-UCPA9BN;database=Batch9;user Id=sa;password=Anaiyaan@123;";                    
                        con.Open();
                        con.Execute(updateQuery);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
                public void DeleteUser(long regID)
                {
                    try
                    {


                        var deleteQuery = $"Delete from registration Where registrationId={regID}";
                        // var ConnectionString = "server=DESKTOP-UCPA9BN;database=Batch9;user Id=sa;password=Anaiyaan@123;";                    
                        con.Open();
                        con.Execute(deleteQuery);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
         }
    

