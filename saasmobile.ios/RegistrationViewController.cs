using System;

using UIKit;

using SaaSMobile;
using Foundation;
using System.Text.RegularExpressions;

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
            var fName = txtFName.Text;
            var lName = txtLName.Text;
            var bDate = (DateTime) bDatePicker.Date;
            var zip = txtZipCode.Text;
            var country = txtCountry.Text;
            var email = txtEmail.Text;
            var pswd = txtPswd.Text;

            if (ShouldPerformSegue("finishRegisterSegue", sender))
            {
                StudyParticipant sp = new StudyParticipant(fName, lName, bDate, zip, country, email, pswd);
                MockStudyParticipantTable.AddParticipant(sp);
            }
            else
            {
                var invalidAlert = UIAlertController.Create("You need to fill out all fields.", "Please try again.", UIAlertControllerStyle.Alert);
                invalidAlert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, alert => Console.WriteLine("Okay was clicked")));
                PresentViewController(invalidAlert, true, null);
            }
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            var fName = txtFName.Text;
            var lName = txtLName.Text;
            var zip = txtZipCode.Text;
            var country = txtCountry.Text;
            var email = txtEmail.Text;
            var pswd = txtPswd.Text;

            int numIncompleteFields = 0;

            if (fName.Length == 0)
            {
                numIncompleteFields++;
            }

            if (lName.Length == 0)
            {
                numIncompleteFields++;
            }

            bool isEmailFormatted = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (email.Length == 0 || !isEmailFormatted)
            {
                numIncompleteFields++;
            }

            if (zip.Length == 0)
            {
                numIncompleteFields++;
            }

            if (country.Length == 0)
            {
                numIncompleteFields++;
            }

            if (pswd.Length == 0)
            {
                numIncompleteFields++;
            }

            return numIncompleteFields == 0;
        }
    }
}

