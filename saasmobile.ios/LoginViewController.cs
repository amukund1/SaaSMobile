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
            // Perform any additional setup after loading the view, typically from a nib.
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
            return areCredentialsValid();
        }


        private bool areCredentialsValid()
        {
            string handle = loginEmailHandle.Text;
            string domain = loginEmailDomain.Text;
            string pswd = loginPswd.Text;

            foreach (StudyParticipant sp in MockStudyParticipantTable.getTable())
            {
                if (handle.Equals(sp.EmailHandle) && domain.Equals(sp.EmailDomain) && pswd.Equals(sp.Password))
                {
                    return true;
                }
            }

            return false;
        }

        partial void BeginRegisterButton_TouchUpInside(UIButton sender)
        {
            PerformSegue("beginRegisterSegue", sender);
        }
    }
}

