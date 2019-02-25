using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Android.Views;
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

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "Setting";

            LogoutButton = FindViewById<Button>(Resource.Id.logoutButton);

            LogoutButton.Click += delegate
            {
                MockStudyParticipantTable.CurrentParticipant = null;
                StartActivity(typeof(LoginActivity));
                Finish();
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.toolbar_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menu_study:
                    StartActivity(typeof(StudyActivity));
                    Finish();
                    return true;
                case Resource.Id.menu_data:
                    StartActivity(typeof(DataActivity));
                    Finish();
                    return true;
                case Resource.Id.menu_profile:
                    StartActivity(typeof(ProfileActivity));
                    Finish();
                    return true;
                case Resource.Id.menu_setting:
                    StartActivity(typeof(SettingActivity));
                    Finish();
                    return true;
                default:
                    return false;
            }
        }
    }
}