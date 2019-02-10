using System;
namespace SaaSMobile
{
    public class Researcher
    {
        private static int id;

        public Researcher(string fName, string lName, string email)
        {
            FirstName = fName;
            LastName = lName;
            Email = email;
        }

        public string FirstName
        {
            get;
        }

        public string LastName
        {
            get;
        }

        public string Email
        {
            get;
        }
    }
}
