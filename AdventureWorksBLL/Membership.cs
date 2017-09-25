using System;
using System.Collections.Generic;
using System.Text;

using AdventureWorksModel;
using AdventureWorksDAL;

namespace AdventureWorksBLL
{
    public enum LoginStatus
    {
        LoggedOn,
        Inexistent,
        InvalidPwd,
        Locked
    }

    public class LoginResult
    {
        private LoginStatus loginStatus;
        private User userInfo;

        public LoginStatus LoginStatus
        {
            get { return loginStatus; }
            set { loginStatus = value; }
        }
        public User UserInfo
        {
            get { return userInfo; }
            set { userInfo = value; }
        }
    }

    public class Membership
    {
        // Navigation constants

        /// <summary>
        /// Default constructor
        /// </summary>
        public Membership()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="candidate"></param>
        /// <returns>See LoginStatus enum</returns>
        public LoginResult AuthenticateUser(string email, string candidate)
        {
            LoginResult loginResult = new LoginResult();

            User userInfo = GetUser(email);

            if (userInfo == null)
                loginResult.LoginStatus = LoginStatus.Inexistent;
            else
            {
                if (BCrypt.CheckPassword(candidate, userInfo.PasswordHash))
                    loginResult.LoginStatus = LoginStatus.LoggedOn;
                else
                    loginResult.LoginStatus = LoginStatus.InvalidPwd;                
            }

            loginResult.UserInfo = userInfo;

            return loginResult;
        }

        /// <summary>
        /// </summary>
        /// <param name="userId">User's email</param>
        /// <returns>User object if a user with that email is found</returns>
        public User GetUser(string email)
        {
            AdventureWorksDAL.Membership membership = new AdventureWorksDAL.Membership();
            User userInfo = new User();

            userInfo = membership.GetUser(email);

            return userInfo;

        }

    }
}
