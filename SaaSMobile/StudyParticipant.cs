using System;

namespace SaaSMobile
{
    public class StudyParticipant
    {
        private static int id = 0;



        public StudyParticipant(string firstName, string lastName, DateTime dob, string emailAddress, string password)
        {
            ++id;
            Id = id;

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            EmailAddress = emailAddress;
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

        public string EmailAddress
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
    }
}
