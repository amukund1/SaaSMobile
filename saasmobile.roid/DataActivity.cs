using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace saasmobile.roid
{
    [Activity(Label = "DataActivity")]
    public class DataActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.data_activity);
        }
    }
}