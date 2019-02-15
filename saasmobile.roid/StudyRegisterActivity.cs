using Android.App;
using Android.OS;
using Android.Widget;
using SaaSMobile;
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
            var adapter = new ArrayAdapter<Study>(this, Resource.Layout.study_activity_list, repo.ToArray());
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            var intent = new Intent(this, typeof(StudyRegisterDetailActivity));

            var selectedItem = ((ArrayAdapter<Study>)ListAdapter).GetItem(position);
            intent.PutExtra("id", selectedItem.Id);

            StartActivity(intent);
        }
    }
}