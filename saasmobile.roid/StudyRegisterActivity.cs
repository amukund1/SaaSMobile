using Android.App;
using Android.OS;
using Android.Widget;
using SaaSMobile;
using System.Collections.Generic;
using Android.Views;
using Android.Content;

namespace saasmobile.roid
{
    [Activity(Label = "StudyRegisterActivity")]
    public class StudyRegisterActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.study_register_activity);

            var repo = MockStudiesRepository.GetRepo();
            StudyParticipant currentUser = MockStudyParticipantTable.CurrentParticipant;
            var registeredStudies = MockParticipantStudyLists.GetParticipantRegisteredStudies(currentUser);

            if (registeredStudies != null)
            {
                var studiesList = ToList(registeredStudies);
                var reduced_repo = repo;
                foreach (Study study in registeredStudies)
                {
                    reduced_repo.Remove(study);
                }
                this.ListAdapter = new ArrayAdapter<Study>(this, Resource.Layout.study_activity_list, reduced_repo.ToArray());
            }
            else
            {
                this.ListAdapter = new ArrayAdapter<Study>(this, Resource.Layout.study_activity_list, repo.ToArray());
            }
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            var intent = new Intent(this, typeof(StudyRegisterDetailActivity));

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
    }
}