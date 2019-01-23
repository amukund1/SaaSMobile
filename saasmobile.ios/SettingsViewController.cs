using System;

using UIKit;

namespace saasmobile.ios
{
    public partial class SettingsViewController : UIViewController
    {
        public SettingsViewController() : base("SettingsViewController", null)
        {
        }

        protected internal SettingsViewController(IntPtr handle) : base(handle)
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

        partial void LogoutButton_TouchUpInside(UIButton sender)
        {

        }
    }
}

