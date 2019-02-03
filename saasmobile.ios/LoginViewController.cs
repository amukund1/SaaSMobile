using System;

using UIKit;

using SaaSMobile;
using Foundation;

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

            loginEmail.Text = MockStudyParticipantTable.CurrentParticipant.Email;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void LoginButton_TouchUpInside(UIButton sender)
        {
            if (!ShouldPerformSegue("loginSegue", sender))
            {
                var alert = UIAlertController.Create("Incorrect Credentials Entered", "Please try again.", UIAlertControllerStyle.Alert);
                ShowViewController(alert, null);
            }
        }


        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if (segueIdentifier.Equals("loginSegue"))
            {
                return AreCredentialsValid();
            }
            return true;
        }


        private bool AreCredentialsValid()
        {
            StudyParticipant curParticipant = MockStudyParticipantTable.CurrentParticipant;
            string pswd = loginPswd.Text;


            return pswd.Equals(curParticipant.Password);
        }
    }
}

