using System;

namespace SaaSMobile
{
    public class StudyParticipant
    {
        private static int id = 0;



        public StudyParticipant(string firstName, string lastName, DateTime dob, string emailHandle, string emailDomain, string password)
        {
            ++id;
            Id = id;

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            EmailHandle = emailHandle;
            EmailDomain = emailDomain;
            Password = password;

            IsActive = true;
        }

        public int Id
        {
            get;
        }

        public string FirstName
        {
            get;
        }

        public string LastName
        {
            get;
        }

        public DateTime DateOfBirth
        {
            get;
        }

        public string EmailHandle
        {
            get;
            set;
        }

        public string EmailDomain
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
