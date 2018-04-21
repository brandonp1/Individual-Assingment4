using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace IndividualAssignment4
{
    [Activity(Label = "IndividualAssignment4", MainLauncher = true)]
    public class MainActivity : Activity
    {
        EditText txtUsername;
        EditText txtPassword;
        Button btnLogIn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
            txtUsername = FindViewById < EditText>(Resource.Id.txtPassword);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogIn = FindViewById<Button>(Resource.Id.btnLogIn);

            btnLogIn.Click += BtnLogIn_Click;

        }

        private void BtnLogIn_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(AccountActivity));
        }
    }
}

