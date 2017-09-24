using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{
    public enum UserStatus
    {
        Active,
        Inactive,
        Locked
    }
    public class User
    {
        private int userId;
        private string email;
        private string passwordHash;
        private string passwordSalt;
        private DateTime createdDate;
        private DateTime modifiedDate;
        private UserStatus status;

        public int UserId {
            get { return userId; }
            set { userId = value; }
        }
        public string Email {
            get { return email; }
            set { email = value; }
        }
        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }
        public string PasswordSalt
        {
            get { return passwordSalt; }
            set { passwordSalt = value; }
        }
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }
        public UserStatus Status {
            get { return status; }
            set { status = value; }
        }
    }
}
