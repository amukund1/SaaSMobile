namespace SaaSMobile
{
    public class Study
    {
        private static int id = 0;
             
        public Study(string name, string description, Researcher admin, StudyConstraints constraints)
        {
            ++id;
            Id = id;

            Name = name;
            Description = description;
            AdminResearcher = admin;
            Constraints = constraints;
        }

        public int Id
        {
            get;
        }

        public string Name
        {
            get;
        }

        public string Description
        {
            get;
        }

        public Researcher AdminResearcher
        {
            get;
        }

        public StudyConstraints Constraints
        {
            get;
        }
    }
}
