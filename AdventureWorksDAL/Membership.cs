using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AdventureWorksModel;

namespace AdventureWorksDAL
{
    public class Membership
    {
        public AdventureWorksModel.User GetUser(string email)
        {
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            string connString = ConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            // Define parameter used in command object
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Email";
            param.Value = email;
            param.SqlDbType = SqlDbType.VarChar;

            // create a command object
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspGetUser";

            cmd.Parameters.Add(param);

            AdventureWorksModel.User usr = new AdventureWorksModel.User();

            try
            {
                // open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();


                // 2. add each Category object to return list
                if (rdr.Read())
                {
                    usr.UserId = (int)rdr["UserID"];
                    usr.Email = (string)rdr["Email"];
                    usr.PasswordHash = (string)rdr["PasswordHash"];
                    usr.PasswordSalt = (string)rdr["PasswordSalt"];
                    usr.CreatedDate = (DateTime)rdr["CreatedDate"];
                    usr.ModifiedDate = (DateTime)rdr["ModifiedDate"];
                    usr.Status = (UserStatus)rdr["Status"];
                }
            }
            finally
            {
                // 3. close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return usr;
        }

        public AdventureWorksModel.UserProfile GetUserProfile(int userId)
        {
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            string connString = ConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            // Define parameter used in command object
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@UserID";
            param.Value = userId;
            param.SqlDbType = SqlDbType.Int;

            // create a command object
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspGetUserProfile";

            cmd.Parameters.Add(param);

            AdventureWorksModel.UserProfile usrProfile = new AdventureWorksModel.UserProfile();

            try
            {
                // open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();


                // 2. add each Category object to return list
                if (rdr.Read())
                {
                    usrProfile.ProfileId = (int)rdr["ProfileID"];
                    usrProfile.UserId = (int)rdr["UserID"];
                    usrProfile.FirstName = (string)rdr["Email"];
                    usrProfile.MiddleName = (string)rdr["PasswordHash"];
                    usrProfile.LastName = (string)rdr["PasswordSalt"];
                    usrProfile.BirthDate = (DateTime)rdr["BirthDate"];
                    usrProfile.Age = (int)rdr["Age"];
                    usrProfile.Gender = (string)rdr["Gender"];
                    usrProfile.MaritalStatus = (MaritalStatus)rdr["MaritalStatus"];
                    usrProfile.HasChildren = (bool)rdr["HasChildren"];
                    usrProfile.AddressLine1 = (string)rdr["AddressLine1"];
                    usrProfile.AddressLine2 = (string)rdr["AddressLine2"];
                    usrProfile.City = (string)rdr["City"];
                    usrProfile.State = (int)rdr["State"];
                    usrProfile.ZipCode = (string)rdr["ZipCode"];
                    usrProfile.Country = (int)rdr["Country"];
                    usrProfile.TimeZone = (AdventureWorksModel.TimeZone)rdr["TimeZone"];
                    usrProfile.CreatedDate = (DateTime)rdr["CreatedDate"];
                    usrProfile.ModifiedDate = (DateTime)rdr["ModifiedDate"];
                }
            }
            finally
            {
                // 3. close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return usrProfile;
        }
    }
}
