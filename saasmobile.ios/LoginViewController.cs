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
                var invalidAlert = UIAlertController.Create("Incorrect password entered.", "Please try again.", UIAlertControllerStyle.Alert);
                invalidAlert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, alert => Console.WriteLine("Okay was clicked")));
                PresentViewController(invalidAlert, true, null);
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

