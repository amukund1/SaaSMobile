using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Android.Views;
using SaaSMobile;

namespace saasmobile.roid
{
    [Activity(Label = "ProfileActivity")]
    public class ProfileActivity : AppCompatActivity
    {
        private string ZipCode;
        private string Country;
        private string Password;
        private Button Update;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.profile_activity);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "Profile";

            StudyParticipant currentUser = MockStudyParticipantTable.CurrentParticipant;
            FindViewById<TextView>(Resource.Id.firstNameUpdateText).SetText("First Name: " + currentUser.FirstName, TextView.BufferType.Editable);
            FindViewById<TextView>(Resource.Id.lastNameUpdateText).SetText("Last Name: " + currentUser.LastName, TextView.BufferType.Editable);
            FindViewById<TextView>(Resource.Id.dateOfBirthUpdateText).SetText("Date of Birth: " + currentUser.DateOfBirth, TextView.BufferType.Editable);
            FindViewById<TextView>(Resource.Id.emailUpdateText).SetText("Email: " + currentUser.Email, TextView.BufferType.Editable);

            FindViewById<EditText>(Resource.Id.zipCodeUpdateText).SetText(currentUser.ZipCode, TextView.BufferType.Editable);
            FindViewById<EditText>(Resource.Id.countryUpdateText).SetText(currentUser.Country, TextView.BufferType.Editable);
            FindViewById<EditText>(Resource.Id.passwordUpdateText).SetText(currentUser.Password, TextView.BufferType.Editable);

            Update = FindViewById<Button>(Resource.Id.updateProfileButton);

            Update.Click += delegate
            {
                ZipCode = FindViewById<EditText>(Resource.Id.zipCodeUpdateText).Text;
                Country = FindViewById<EditText>(Resource.Id.countryUpdateText).Text;
                Password = FindViewById<EditText>(Resource.Id.passwordUpdateText).Text;

                currentUser.ZipCode = ZipCode;
                currentUser.Country = Country;
                currentUser.Password = Password;

                StartActivity(typeof(ProfileActivity));
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