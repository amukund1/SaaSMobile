using System;
using System.Collections.Generic;

namespace SaaSMobile
{
    public static class MockStudiesRepository
    {
        private static List<Study> repository = new List<Study>() { 
            new Study("Study 1", "Study 1 Info", new Researcher("Joe", "Smith", "joesmith@domain.com"), new StudyConstraints(19)),
            new Study("Study 2", "Study 2 Info", new Researcher("Joe", "Smith", "joesmith@domain.com"), new StudyConstraints(19))
            };


        public static List<Study> GetRepo()
        {
            return repository;
        }
    }
}
