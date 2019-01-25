using System;
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
        private EditText Email;
        private EditText Password;
        private Button Login;
        private Button Register;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the login layout resource
            SetContentView(Resource.Layout.login_activity);

            Email = (EditText)FindViewById(Resource.Id.emailText);
            Password = (EditText)FindViewById(Resource.Id.passwordText);
            Login = (Button)FindViewById(Resource.Id.loginButton);
            Register = (Button)FindViewById(Resource.Id.registerButton);

            Login.Click += delegate {
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
        }

        private bool AreCredentialsValid()
        {
            String email = Email.Text;
            Console.Write(email);
            String password = Password.Text;

            int atIndex = email.IndexOf("@");
            string handle = email.Substring(0, atIndex);
            string domain = email.Substring(atIndex);

            foreach (StudyParticipant sp in MockStudyParticipantTable.getTable())
            {
                if (handle.Equals(sp.EmailHandle) && domain.Equals(sp.EmailDomain) && password.Equals(sp.Password))
                {
                    MockStudyParticipantTable.CurrentParticipant = sp;
                    return true;
                }
            }
            return false;
        }
    }
}