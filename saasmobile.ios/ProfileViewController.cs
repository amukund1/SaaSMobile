using System;

using UIKit;

using SaaSMobile;

namespace saasmobile.ios
{
    public partial class ProfileViewController : UIViewController
    {
        public ProfileViewController() : base("ProfileViewController", null)
        {
        }

        protected internal ProfileViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            StudyParticipant curParticipant = MockStudyParticipantTable.CurrentParticipant;

            profileFName.Text = curParticipant.FirstName;
            profileLName.Text = curParticipant.LastName;
            profileBDate.Text = curParticipant.DateOfBirth.Date.ToString("MM/dd/yyyy");
            profileZipCode.Text = curParticipant.ZipCode;
            profileCountry.Text = curParticipant.Country;
            profileEmail.Text = curParticipant.Email;
            profilePswd.Text = curParticipant.Password;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

