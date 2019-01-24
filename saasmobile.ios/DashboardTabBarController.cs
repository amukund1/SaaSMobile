using System;

using UIKit;

using SaaSMobile;
using Foundation;

namespace saasmobile.ios
{
    public partial class DashboardTabBarController : UITabBarController
    {
        public StudyParticipant CurrentParticipant
        {
            get;
            set;
        }

        public DashboardTabBarController() : base("DashboardTabBarController", null)
        {
        }

        protected internal DashboardTabBarController(IntPtr handle) : base(handle)
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

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var profileViewController = segue.DestinationViewController as ProfileViewController;

            profileViewController.CurrentParticipant = CurrentParticipant;
        }
    }
}

