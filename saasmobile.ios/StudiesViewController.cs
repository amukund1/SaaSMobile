using System;

using UIKit;

namespace saasmobile.ios
{
    public partial class StudiesViewController : UIViewController
    {
        public StudiesViewController() : base("StudiesViewController", null)
        {
        }

        protected internal StudiesViewController(IntPtr handle) : base(handle)
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

