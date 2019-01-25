using Android.App;
using Android.OS;
using Android.Widget;
using SaaSMobile;
using System.Globalization;

namespace saasmobile.roid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        private string FirstName;
        private string LastName;
        private string DateOfBirth;
        private string Email;
        private string EmailHandle;
        private string EmailDomain;
        private string Password;
        private string ReEnterPassword;
        private Button RegisterButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.register_activity);
            
            RegisterButton = FindViewById<Button>(Resource.Id.registeringButton);
            

            RegisterButton.Click += delegate
            {
                string firstName = FindViewById<EditText>(Resource.Id.firstNameRegisterText).Text;
                FirstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
                string lastName = FindViewById<EditText>(Resource.Id.lastNameRegisterText).Text;
                LastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
                DateOfBirth = FindViewById<EditText>(Resource.Id.dateOfBirthRegisterButton).Text;
                Email = FindViewById<EditText>(Resource.Id.emailRegisterText).Text.ToLower();
                ReEnterPassword = FindViewById<EditText>(Resource.Id.reEnterPasswordRegisterText).Text;
                Password = FindViewById<EditText>(Resource.Id.passwordRegisterText).Text;

                //missing dateofbirth to be implemented
                if (HasMissingFields())
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Missing One Or More Fields");
                    alert.SetMessage("You are missing some fields. Please enter all of the information and try again.");
                    alert.Show();
                }
                else if (IsEmailMissingAtSign())
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Email Does Not Contain @");
                    alert.SetMessage("The email you have entered does not contain an @ sign. Please try again.");
                    alert.Show();
                }
                // this also sets the email handle and domain
                else if (IsEmailRegistered())
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Email In Use");
                    alert.SetMessage("The email you have entered is already registered. Please try again with a different email.");
                    alert.Show();
                }
                else if (DoPasswordsMatch())
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Passwords Do Not Match");
                    alert.SetMessage("The passwords that you have entered do not match. Please try again.");
                    alert.Show();
                }
                else
                {
                    // date of birth to be implemented
                    StudyParticipant newUser = new StudyParticipant(FirstName, LastName, new System.DateTime(1999, 1, 1), EmailHandle, EmailDomain, Password);
                    MockStudyParticipantTable.AddParticipant(newUser);
                    StartActivity(typeof(LoginActivity));
                }
            };
        }

        private bool HasMissingFields()
        {
            return string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ReEnterPassword) || DateOfBirthNotSelected();
        }

        private bool DateOfBirthNotSelected()
        {
            return false;
        }

        private bool IsEmailMissingAtSign()
        {
            return !Email.Contains("@");
        }

        private bool IsEmailRegistered()
        {
            SetEmailHandleAndDomain();

            foreach (StudyParticipant sp in MockStudyParticipantTable.getTable())
            {
                if (EmailHandle.Equals(sp.EmailHandle) && EmailDomain.Equals(sp.EmailDomain))
                {
                    return true;
                }
            }
            return false;
        }

        private void SetEmailHandleAndDomain()
        {
            int atIndex = Email.IndexOf("@");
            EmailHandle = Email.Substring(0, atIndex);
            EmailDomain = Email.Substring(atIndex);
        }

        private bool DoPasswordsMatch()
        {
            return Password.Equals(ReEnterPassword);
        }
    }
}