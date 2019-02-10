namespace SaaSMobile
{
    public struct StudyConstraints
    {
        public StudyConstraints(int minAge)
        {
            MinAge = minAge;
        }

        public int MinAge
        {
            get;
        }
    }
}