using System;
using System.Collections.Generic;

namespace SaaSMobile
{
    public class MockStudyParticipantRepository
    {
        private List<StudyParticipant> _repository;

        public MockStudyParticipantRepository()
        {
            _repository = new List<StudyParticipant>();
        }

        public List<StudyParticipant> GetRepository()
        {
            return _repository;
        }

        public void AddParticipant(StudyParticipant participant)
        {
            _repository.Add(participant);
        }
    }
}
