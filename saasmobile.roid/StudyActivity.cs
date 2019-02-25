using Android.App;
using Android.OS;
using Android.Widget;
using SaaSMobile;
using System.Collections.Generic;
using Android.Views;
using Android.Content;

namespace saasmobile.roid
{
    [Activity(Label = "StudyActivity")]
    public class StudyActivity : ListActivity
    {
        private Button ViewStudyRegisterButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.study_activity);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "Study";

            ViewStudyRegisterButton = FindViewById<Button>(Resource.Id.viewStudyRegisterButton);

            StudyParticipant currentUser = MockStudyParticipantTable.CurrentParticipant;
            var registeredStudies = MockParticipantStudyLists.GetParticipantRegisteredStudies(currentUser);
            if (registeredStudies != null)
            {
                var studiesList = ToList(registeredStudies);
                this.ListAdapter = new ArrayAdapter<Study>(this, Resource.Layout.study_activity_list, studiesList.ToArray());
            }
            else
            {
                this.ListAdapter = new ArrayAdapter<Study>(this, Resource.Layout.study_activity_list, new List<Study>());
            }

            ViewStudyRegisterButton.Click += delegate
            {
                StartActivity(typeof(StudyRegisterActivity));
            };
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            var intent = new Intent(this, typeof(StudyDetailActivity));

            var selectedItem = ((ArrayAdapter<Study>)ListAdapter).GetItem(position);
            intent.PutExtra("id", selectedItem.Id);

            StartActivity(intent);
        }

        private List<Study> ToList(HashSet<Study> studies)
        {
            List<Study> studiesList = new List<Study>();
            foreach (Study study in studies)
            {
                studiesList.Add(study);
            }
            return studiesList;
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