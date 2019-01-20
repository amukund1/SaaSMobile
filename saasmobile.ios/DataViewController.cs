using System;

using UIKit;

namespace saasmobile.ios
{
    public partial class DataViewController : UIViewController
    {
        public DataViewController() : base("DataViewController", null)
        {
        }

        protected internal DataViewController(IntPtr handle) : base(handle)
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

