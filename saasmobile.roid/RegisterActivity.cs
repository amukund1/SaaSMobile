using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SaaSMobile;

namespace saasmobile.roid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : AppCompatActivity
    {
        private string FirstName;
        private string LastName;
        private string DateOfBirthString;
        private System.DateTime DateOfBirth;
        private string ZipCode;
        private string Country;
        private string Email;
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
                DateOfBirthString = FindViewById<EditText>(Resource.Id.dateOfBirthRegisterText).Text;
                ZipCode = FindViewById<EditText>(Resource.Id.zipCodeRegisterText).Text;
                Country = FindViewById<EditText>(Resource.Id.countryRegisterText).Text;
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
                } else if (DateOfBirthIncorrectFormat())
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Date Of Birth Incorrect Format");
                    alert.SetMessage("The date of birth that you have entered is not in the correct format. Please use mm/dd/yyyy.");
                    alert.Show();
                }
                else if (!DoPasswordsMatch())
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Passwords Do Not Match");
                    alert.SetMessage("The passwords that you have entered do not match. Please try again.");
                    alert.Show();
                }
                else
                {
                    // date of birth to be implemented
                    StudyParticipant newUser = new StudyParticipant(FirstName, LastName, DateOfBirth, ZipCode, Country, Email, Password);
                    MockStudyParticipantTable.AddParticipant(newUser);
                    StartActivity(typeof(LoginActivity));
                    Finish();
                }
            };
        }

        private bool HasMissingFields()
        {
            return string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ReEnterPassword) || string.IsNullOrEmpty(DateOfBirthString);
        }

        private bool DateOfBirthIncorrectFormat()
        {
            if (!DateOfBirthString.Contains("/"))
            {
                return true;
            } else
            {
                string[] monthDateYear = DateOfBirthString.Split("/");
                if (monthDateYear.Length != 3 || monthDateYear[0].Length != 2
                    || monthDateYear[1].Length != 2 || monthDateYear[2].Length != 4)
                {
                    return true;
                } else
                {
                    DateOfBirth = new System.DateTime(int.Parse(monthDateYear[2]), int.Parse(monthDateYear[0]), int.Parse(monthDateYear[1]));
                    return false;
                }
            }
        }

        private bool IsEmailMissingAtSign()
        {
            return !Email.Contains("@");
        }

        private bool IsEmailRegistered()
        {
            foreach (StudyParticipant sp in MockStudyParticipantTable.getTable())
            {
                if (Email.Equals(sp.Email))
                {
                    return true;
                }
            }
            return false;
        }

        private bool DoPasswordsMatch()
        {
            return string.Equals(Password, ReEnterPassword);
        }
    }
}