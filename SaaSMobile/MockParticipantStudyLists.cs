using System;
using System.Collections;
using System.Collections.Generic;

namespace SaaSMobile
{
    public static class MockParticipantStudyLists
    {
        private static Hashtable participantStudyLists = new Hashtable();
       
        public static void JoinStudy(StudyParticipant sp, Study s)
        {
            if (!participantStudyLists.ContainsKey(sp))
            {
                participantStudyLists.Add(sp, new HashSet<Study>() { s });
            }
            else
            {
                HashSet<Study> studiesList = (HashSet<Study>) participantStudyLists[sp];
                studiesList.Add(s);
            }
        }

        public static HashSet<Study> GetParticipantRegisteredStudies(StudyParticipant sp)
        {
            return (HashSet<Study>) participantStudyLists[sp];
        }

        public static int Size()
        {
            return participantStudyLists.Count;
        }

    }
}
