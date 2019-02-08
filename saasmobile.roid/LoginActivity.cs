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
        private string Email;
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

                Email = FindViewById<EditText>(Resource.Id.emailText).Text.ToLower();
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
                if (Email.Equals(sp.Email) && Password.Equals(sp.Password))
                {
                    MockStudyParticipantTable.CurrentParticipant = sp;
                    return true;
                }
            }
            return false;
        }
    }
}