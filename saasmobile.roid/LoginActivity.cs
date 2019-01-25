using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SaaSMobile;

namespace saasmobile.roid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {
        private string Password;
        private string EmailHandle;
        private string EmailDomain;
        private Button Login;
        private Button Register;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the login layout resource
            SetContentView(Resource.Layout.login_activity);

            Login = FindViewById<Button>(Resource.Id.loginButton);
            Register = FindViewById<Button>(Resource.Id.registerButton);

            Login.Click += delegate {

                string email = FindViewById<EditText>(Resource.Id.emailText).Text.ToLower();
                int atIndex = email.IndexOf("@");
                EmailHandle = email.Substring(0, atIndex);
                EmailDomain = email.Substring(atIndex);
                Password = FindViewById<EditText>(Resource.Id.passwordText).Text;

                if (AreCredentialsValid()) {
                    StartActivity(typeof(DashboardActivity));
                } else
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Incorrect Credentials");
                    alert.SetMessage("Incorrect Credentials Entered. Please try again.");
                    alert.Show();
                }
            };

            Register.Click += delegate
            {
                StartActivity(typeof(RegisterActivity));
            };
        }

        private bool AreCredentialsValid()
        {
            foreach (StudyParticipant sp in MockStudyParticipantTable.getTable())
            {
                if (EmailHandle.Equals(sp.EmailHandle) && EmailDomain.Equals(sp.EmailDomain) && Password.Equals(sp.Password))
                {
                    MockStudyParticipantTable.CurrentParticipant = sp;
                    return true;
                }
            }
            return false;
        }
    }
}