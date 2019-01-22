using System;

using UIKit;

using SaaSMobile;
using Foundation;

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
            var handle = txtEmailHandle.Text;
            var domain = txtEmailDomain.Text;
            var pswd = txtPswd.Text;

            if (ShouldPerformSegue("finishRegisterSegue", sender))
            {
                StudyParticipant sp = new StudyParticipant(fName, lName, bDate, handle, domain, pswd);
                MockStudyParticipantTable.AddParticipant(sp);
                //PerformSegue("finishRegisterSegue", sender);
            }
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            var fName = txtFName.Text;
            var lName = txtLName.Text;
            var handle = txtEmailHandle.Text;
            var domain = txtEmailDomain.Text;
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

            if (handle.Length == 0)
            {
                numIncompleteFields++;
            }

            if (domain.Length == 0)
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

