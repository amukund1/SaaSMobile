﻿using System;

namespace SaaSMobile
{
    public class StudyParticipant
    {
        private static int id = 0;

        public StudyParticipant(string firstName, string lastName, DateTime dob, string zip, string country, string email, string password)
        {
            ++id;
            Id = id;

            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            ZipCode = zip;
            Country = country;
            Email = email;
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

        public string ZipCode
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public string Email
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
