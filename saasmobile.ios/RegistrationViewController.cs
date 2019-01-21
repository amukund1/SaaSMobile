using System;

using UIKit;

namespace saasmobile.ios
{
    public partial class RegistrationViewController : UIViewController
    {
        public RegistrationViewController() : base("RegistrationViewController", null)
        {
        }

        protected internal RegistrationViewController(IntPtr handle) : base(handle)
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

