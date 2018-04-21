using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace IndividualAssignment4.Activities
{
    [Activity(Label = "AccountActivity")]
    public class AccountActivity : Activity
    {
        Button btnSavingsAccount;
        Button btnCheckingAccount;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AccountLayout);

            btnSavingsAccount = FindViewById<Button>(Resource.Id.btnSavings);
            btnCheckingAccount = FindViewById<Button>(Resource.Id.btnChecking);


            btnCheckingAccount.Click += BtnCheckingAccount_Click;
            btnSavingsAccount.Click += BtnSavingsAccount_Click;
            
        }

        private void BtnSavingsAccount_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Activities.SavingActivity));
            StartActivity(intent);
        }

        private void BtnCheckingAccount_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Activities.CheckingActivity));
            StartActivity(intent);
        }
    }
}