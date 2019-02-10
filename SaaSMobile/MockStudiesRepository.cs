using System;
using System.Collections;

namespace SaaSMobile
{
    public static class MockStudiesRepository
    {
        private static ArrayList repository = new ArrayList() { new Study("Study 1", "Study 1 Info", new ArrayList() { new Researcher("Joe", "Smith", "joesmith@domain.com") }, new StudyConstraints(19)) };


        public static ArrayList GetRepo()
        {
            return repository;
        }
    }
}
