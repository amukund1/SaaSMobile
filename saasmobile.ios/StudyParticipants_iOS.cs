using System;
using Firebase.Auth;
using Firebase.Core;
using Firebase.Database;

namespace saasmobile.ios
{
    public class StudyParticipants_iOS
    {
        private static StudyParticipants_iOS instance;

        public static DatabaseReference ParticipantsNode
        {
            get;
            set;
        }

        public static Auth auth;

        private StudyParticipants_iOS()
        {
            //connect to Firebase
            App.Configure();

            // seek the participants node
            ParticipantsNode = Database.DefaultInstance.GetRootReference().GetChild("participants");

            auth = Auth.DefaultInstance;
        }

        public static StudyParticipants_iOS GetInstance()
        {

            if (instance == null)
            {
                instance = new StudyParticipants_iOS();
            }

            return instance;
        }
    }
}
