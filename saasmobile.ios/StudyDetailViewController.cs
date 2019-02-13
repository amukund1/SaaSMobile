using System;

using UIKit;

using SaaSMobile;

namespace saasmobile.ios
{
    public partial class StudyDetailViewController : UIViewController
    {
        private Study _study;

        public void SetStudy(Study study)
        {
            _study = study;
        }

        public StudyDetailViewController() : base("StudyDetailViewController", null)
        {
        }

        protected internal StudyDetailViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            studyName.Text = _study.Name;
            studyDescription.Text = _study.Description;
            studyOwner.Text = _study.AdminResearcher.Email;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void StudyRegisterButton_TouchUpInside(UIButton sender)
        {
            StudyParticipant curParticipant = MockStudyParticipantTable.CurrentParticipant;

            MockParticipantStudyLists.JoinStudy(curParticipant, _study);
        }
    }
}

