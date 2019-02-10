using System;
using System.Collections;

namespace SaaSMobile
{
    public class Study
    {
        private static int id = 0;
             
        public Study(string name, string description, ArrayList researchers, StudyConstraints constraints)
        {
            ++id;
            Name = name;
            Description = description;
            Researchers = researchers;
            Constraints = constraints;
        }

        public string Name
        {
            get;
        }

        public string Description
        {
            get;
        }

        public ArrayList Researchers
        {
            get;
        }

        public StudyConstraints Constraints
        {
            get;
        }
    }
}
