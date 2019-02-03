using System;
using System.Collections;

namespace SaaSMobile
{
    public static class MockStudyParticipantTable
    {
        private static ArrayList table = new ArrayList() { new StudyParticipant("Adithya", "Mukund", new DateTime(1998, 07, 15), "adithyam120@gmail.com", "123") };

        public static StudyParticipant CurrentParticipant
        {
            get;
            set;
        }

        public static void AddParticipant(StudyParticipant participant)
        {
            table.Add(participant);
        }

        public static ArrayList getTable()
        {
            return table;
        }
    }
}
