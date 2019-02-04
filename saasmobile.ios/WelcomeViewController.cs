using System;
using Foundation;
using UIKit;
using SaaSMobile;
using System.Text.RegularExpressions;

namespace saasmobile.ios
{
    public partial class WelcomeViewController : UIViewController
    {
        public WelcomeViewController() : base("WelcomeViewController", null)
        {
        }

        protected internal WelcomeViewController(IntPtr handle) : base(handle)
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

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if (segueIdentifier.Equals("beginLoginSegue"))
            {
                return IsEmailValid();
            }

            return true;
        }

        private bool IsEmailValid()
        {
            string email = welcomeEmail.Text;

            bool isEmailFormatted = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (!isEmailFormatted)
            {
                return false;
            }

            foreach (StudyParticipant sp in MockStudyParticipantTable.getTable())
            {
                if (email.Equals(sp.Email))
                {
                    MockStudyParticipantTable.CurrentParticipant = sp;
                    return true;
                }
            }

            return false;
        }


        partial void WelcomeLoginButton_TouchUpInside(UIButton sender)
        {
            if (!ShouldPerformSegue("beginLoginSegue", sender))
            {
                var invalidAlert = UIAlertController.Create("You need to enter a valid email address.", "Please try again.", UIAlertControllerStyle.Alert);
                invalidAlert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, alert => Console.WriteLine("Okay was clicked")));
                PresentViewController(invalidAlert, true, null);
            }
        }

        partial void WelcomeRegisterButton_TouchUpInside(UIButton sender)
        {

        }
    }
}

