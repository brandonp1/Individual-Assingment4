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
    [Activity(Label = "CheckingTransaction")]
    public class CheckingActivity : Activity
    {
        ListView lstTransactions;
        List<string> transactions;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TransactionLayout);
            lstTransactions = FindViewById<ListView>(Resource.Id.lstTransaction);
            transactions = new List<string>();
            transactions.Add("Apple ----- 4/20/18");
            transactions.Add("Walmart ----- 4/10/18");
            transactions.Add("Target ----- 4/11/18");
            transactions.Add("McDonalds ----- 4/12/18");
            transactions.Add("Culvers ----- 4/13/18");
            transactions.Add("Microsoft ----- 4/14/18");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, transactions);
            lstTransactions.Adapter = adapter;

            // Create your application here
        }
    }
}