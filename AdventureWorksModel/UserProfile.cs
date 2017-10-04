using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorksModel
{
    public enum MaritalStatus
    {
        Single,
        Married,
        Divorced,
        Widowed,
        DomesticPartnership
    }

    public enum TimeZone
    {
        PacificTime,
        MountainTime,
        CentralTime,
        EasternTime
    }

    public class UserProfile
    {
        private int profileId;
        private int userId;
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthDate;
        private int age;
        private string gender;
        private MaritalStatus maritalStatus;
        private bool hasChildren;
        private string addressLine1;
        private string addressLine2;
        private string city;
        private int state;
        private string zipCode;
        private int country;
        private TimeZone timeZone;
        private DateTime createdDate;
        private DateTime modifiedDate;

        public int ProfileId
        {
            get { return profileId; }
            set { profileId = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public double Age
        {
            get
            {
                DateTime reference = DateTime.Today;
                age = reference.Year - this.birthDate.Year;
                if (reference < this.birthDate.AddYears(age)) age--;
                return age;
            }
            set { ; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public MaritalStatus MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }
        public bool HasChildren
        {
            get { return hasChildren; }
            set { hasChildren = value; }
        }
        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public int Country
        {
            get { return country; }
            set { country = value; }
        }
        public TimeZone TimeZone
        {
            get { return timeZone; }
            set { timeZone = value; }
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
    }
}
