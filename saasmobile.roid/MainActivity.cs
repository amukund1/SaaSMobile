using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace saasmobile.roid.Resources
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private string Email;
        private Button Login;
        private Button Register;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.main_activity);

            Login = FindViewById<Button>(Resource.Id.loginButton);
            Register = FindViewById<Button>(Resource.Id.registerButton);

            Login.Click += delegate
            {
                Email = FindViewById<EditText>(Resource.Id.emailText).Text.ToLower();
                var intent = new Android.Content.Intent(this, typeof(LoginActivity));
                intent.PutExtra("email", Email);

                StartActivity(intent);
                Finish();
            };
            Register.Click += delegate
            {
                StartActivity(typeof(RegisterActivity));
                Finish();
            };
        }
    }
}