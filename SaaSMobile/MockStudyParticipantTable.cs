using System;
using System.Collections;

namespace SaaSMobile
{
    public static class MockStudyParticipantTable
    {
        private static ArrayList table = new ArrayList();

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
