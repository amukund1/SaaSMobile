using Android.App;
using Android.OS;
using Android.Widget;

namespace saasmobile.roid
{
    [Activity(Label = "StudyActivity")]
    public class StudyActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.study_activity);
        }
    }
}