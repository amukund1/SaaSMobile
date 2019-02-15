using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SaaSMobile;

namespace saasmobile.roid
{
    [Activity(Label = "StudyDetailActivity")]
    public class StudyDetailActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.study_detail_activity);
            var studyId = Intent.GetIntExtra("id", 0);
            var study = MockStudiesRepository.GetStudy(studyId);

            this.FindViewById<TextView>(Resource.Id.studyDetailNameText).Text = study.Name;
            this.FindViewById<TextView>(Resource.Id.studyDetailDescriptionText).Text = study.Description;
            this.FindViewById<TextView>(Resource.Id.studyDetailContactText).Text = study.AdminResearcher.Email;
        }
    }
}