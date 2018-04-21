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
    [Activity(Label = "SavingsTransaction")]
    public class SavingActivity : Activity
    {
        ListView lstTransactions;
        List<string> transactions;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TransactionLayout);
            lstTransactions = FindViewById<ListView>(Resource.Id.lstTransaction);
            transactions = new List<string>();
            transactions.Add("Deposit ----- 4/20/18");
            transactions.Add("Deposit ----- 4/10/18");
            transactions.Add("Withdrawl ----- 4/11/18");
            transactions.Add("Deposit ----- 4/12/18");
            transactions.Add("Withdrawl ----- 4/13/18");
            transactions.Add("Withdrawl ----- 4/14/18");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, transactions);
            lstTransactions.Adapter = adapter;
        }
    }
}