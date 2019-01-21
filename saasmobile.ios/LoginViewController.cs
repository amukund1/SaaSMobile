using System;

using UIKit;

namespace saasmobile.ios
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewController() : base("LoginViewController", null)
        {
        }

        protected internal LoginViewController(IntPtr handle) : base(handle)
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

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            if (!isValidEmail() || !isValidPassword())
            {
                var alert = UIAlertController.Create("Incorrect Credentials Entered", "Please try again.", UIAlertControllerStyle.Alert);
                ShowViewController(alert, null);
            }
        }


        private bool isValidEmail()
        {
            return !String.IsNullOrEmpty(txtEmail.Text.Trim());
        }

        private bool isValidPassword()
        {
            return !String.IsNullOrEmpty(txtPassword.Text.Trim());
        }

        partial void BeginRegisterButton_TouchUpInside(UIButton sender)
        {

        }
    }
}

