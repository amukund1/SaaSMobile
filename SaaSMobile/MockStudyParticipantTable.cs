using System;
using System.Collections;

namespace SaaSMobile
{
    public class MockStudyParticipantTable
    {
        private ArrayList table;

        public MockStudyParticipantTable()
        {
            table = new ArrayList();
        }

        public void AddParticipant(StudyParticipant participant)
        {
            table.Add(participant);
        }
    }
}
