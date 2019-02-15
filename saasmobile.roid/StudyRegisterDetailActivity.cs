using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SaaSMobile;

namespace saasmobile.roid
{
    [Activity(Label = "StudyRegisterDetailActivity")]
    public class StudyRegisterDetailActivity : AppCompatActivity
    {
        private Button RegisterStudyButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.study_register_detail_activity);
            var studyId = Intent.GetIntExtra("id", 0);
            var study = MockStudiesRepository.GetStudy(studyId);

            this.FindViewById<TextView>(Resource.Id.studyRegisterDetailNameText).Text = study.Name;
            this.FindViewById<TextView>(Resource.Id.studyRegisterDetailDescriptionText).Text = study.Description;
            this.FindViewById<TextView>(Resource.Id.studyRegisterDetailContactText).Text = study.AdminResearcher.Email;

            RegisterStudyButton = FindViewById<Button>(Resource.Id.studyRegisterButton);
            RegisterStudyButton.Click += delegate
            {
                StudyParticipant currentUser = MockStudyParticipantTable.CurrentParticipant;
                MockParticipantStudyLists.JoinStudy(currentUser, study);
                StartActivity(typeof(StudyActivity));
            };
        }
    }
}