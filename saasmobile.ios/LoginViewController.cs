using System;

using UIKit;

using SaaSMobile;
using Foundation;
using System.Net.Mail;
using System.Text.RegularExpressions;

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
            if (segueIdentifier.Equals("loginSegue"))
            {
                return AreCredentialsValid();
            }
            return true;
        }


        private bool AreCredentialsValid()
        {
            string email = loginEmail.Text;
            string pswd = loginPswd.Text;

            bool isEmailFormatted = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmailFormatted)
            {
                return false;
            }



            foreach (StudyParticipant sp in MockStudyParticipantTable.getTable())
            {
                if (email.Equals(sp.Email) && pswd.Equals(sp.Password))
                {
                    MockStudyParticipantTable.CurrentParticipant = sp;
                    return true;
                }
            }

            return false;
        }

        partial void BeginRegisterButton_TouchUpInside(UIButton sender)
        {

        }
    }
}

