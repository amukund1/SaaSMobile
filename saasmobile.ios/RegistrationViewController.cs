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

        partial void FinishRegisterButton_TouchUpInside(UIButton sender)
        {
            if (isFirstNameEmpty() || isLastNameEmpty() || isBirthdateEmpty() || isHandleEmpty() || isDomainEmpty() || isPasswordEmpty())
            {
                var alert = UIAlertController.Create("Empty Fields", "Please complete the entire form.", UIAlertControllerStyle.Alert);
                ShowViewController(alert, null);
            }
        }

        private bool isFirstNameEmpty()
        {
            return txtFName.Text.Length == 0;
        }

        private bool isLastNameEmpty()
        {
            return txtLName.Text.Length == 0;
        }

        private bool isBirthdateEmpty()
        {
            return txtBDate.Text.Length == 0;
        }

        private bool isHandleEmpty()
        {
            return txtEmailHandle.Text.Length == 0;
        }

        private bool isDomainEmpty()
        {
            return txtEmailDomain.Text.Length == 0;
        }

        private bool isPasswordEmpty()
        {
            return txtPswd.Text.Length == 0;
        }
    }
}

