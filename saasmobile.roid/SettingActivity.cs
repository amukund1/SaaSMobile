using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SaaSMobile;

namespace saasmobile.roid
{
    [Activity(Label = "SettingActivity")]
    public class SettingActivity : AppCompatActivity
    {
        private Button LogoutButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.setting_activity);

            LogoutButton = FindViewById<Button>(Resource.Id.logoutButton);

            LogoutButton.Click += delegate
            {
                MockStudyParticipantTable.CurrentParticipant = null;
                StartActivity(typeof(LoginActivity));
                Finish();
            };
        }
    }
}