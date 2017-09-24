using System;
using System.Collections.Generic;
using System.Text;

using AdventureWorksModel;
using AdventureWorksDAL;

namespace AdventureWorksBLL
{
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
        /// </summary>
        /// <param name="userId">User's email</param>
        /// <returns>User object if a user with that email is found</returns>
        public User GetUser(string email)
        {
            Membership membership = new Membership();
            User userInfo = new User();

            userInfo = membership.GetUser(email);

            return userInfo;

        }

    }
}
