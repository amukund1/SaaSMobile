using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SaaSMobile;
using Firebase;
using Firebase.Auth;
using Android.Gms.Tasks;

namespace saasmobile.roid
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : AppCompatActivity, IOnCompleteListener
    {
        private string Password;
        private string Email;
        private Button Login;
        public static FirebaseApp mApp;
        private FirebaseAuth mAuth;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the login layout resource
            SetContentView(Resource.Layout.login_activity);
            var email = Intent.GetStringExtra("email");
            FindViewById<EditText>(Resource.Id.emailLoginText).SetText(email, TextView.BufferType.Editable);

            InitFirebaseAuth();

            Login = FindViewById<Button>(Resource.Id.loginAtLoginButton);

            Login.Click += delegate
            {
                Email = FindViewById<EditText>(Resource.Id.emailLoginText).Text.ToLower();
                Password = FindViewById<EditText>(Resource.Id.passwordLoginText).Text;

                //LoginUser(Email, Password);
                if (AreCredentialsValid())
                {
                    StartActivity(typeof(StudyActivity));
                    Finish();
                }
                else
                {
                    Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                    alert.SetTitle("Incorrect Credentials");
                    alert.SetMessage("Incorrect Credentials Entered. Please try again.");
                    alert.Show();
                }
            };
        }

        private void InitFirebaseAuth()
        {
            var options = new FirebaseOptions.Builder()
            .SetApplicationId("1:981585540799:android:e3946b5d065f5f23")
            .SetApiKey("AIzaSyDaBVGKRVfcBHkkLi6uE_nkvTpG4ELOkn4")
            .Build();

            if (mApp == null)
            {
                mApp = FirebaseApp.InitializeApp(this, options);
            }
            mAuth = FirebaseAuth.GetInstance(mApp);
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

        private void LoginUser(string email, string password)
        {
            mAuth.SignInWithEmailAndPassword(email, password)
                .AddOnCompleteListener(this);
        }

        public void OnComplete(Task task)
        {
            if (task.IsSuccessful)
            {
                StartActivity(typeof(DashboardActivity));
                Finish();
            }
            else
            {
                Android.Support.V7.App.AlertDialog.Builder alert = new Android.Support.V7.App.AlertDialog.Builder(this);
                alert.SetTitle("Incorrect Credentials");
                alert.SetMessage("Incorrect Credentials Entered. Please try again.");
                alert.Show();
            }
        }
    }
}