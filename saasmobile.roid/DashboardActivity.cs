using Android.App;
using Android.OS;
using Android.Widget;
using SaaSMobile;

namespace saasmobile.roid
{
    [Activity(Label = "DashboardActivity")]
    public class DashboardActivity : Activity
    {
        private Button LogoutButton;
        private Button StudyButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.dashboard_activity);

            LogoutButton = FindViewById<Button>(Resource.Id.logoutButton);
            StudyButton = FindViewById<Button>(Resource.Id.studyButton);

            LogoutButton.Click += delegate
            {
                MockStudyParticipantTable.CurrentParticipant = null;
                StartActivity(typeof(LoginActivity));
            };
            StudyButton.Click += delegate
            {
                StartActivity(typeof(StudyActivity));
            };
        }
    }
}