using System;

using UIKit;

using SaaSMobile;

namespace saasmobile.ios
{
    public partial class ProfileViewController : UIViewController
    {
        public StudyParticipant CurrentParticipant
        {
            get;
            set;
        }

        public ProfileViewController() : base("ProfileViewController", null)
        {
        }

        protected internal ProfileViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

