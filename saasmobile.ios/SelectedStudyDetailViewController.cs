using System;

using UIKit;

using SaaSMobile;

namespace saasmobile.ios
{
    public partial class SelectedStudyDetailViewController : UIViewController
    {
        private Study _selectedStudy;

        public void SetSelectedStudy(Study selectedStudy)
        {
            _selectedStudy = selectedStudy;
        }

        public SelectedStudyDetailViewController() : base("SelectedStudyDetailViewController", null)
        {
        }

        protected internal SelectedStudyDetailViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            selectedStudyName.Text = _selectedStudy.Name;
            selectedStudyDescription.Text = _selectedStudy.Description;
            selectedStudyContactInfo.Text = _selectedStudy.AdminResearcher.Email;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

