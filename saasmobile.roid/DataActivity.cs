using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Android.Views;

namespace saasmobile.roid
{
    [Activity(Label = "DataActivity")]
    public class DataActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.data_activity);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "Data";
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