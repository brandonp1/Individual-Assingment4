using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulosIndividualAssignment4
{
    class Transaction
    {
        List<int> AllTransactions = new List<int>();

        int TranactionAmount;
        int TransactionID;
        DateTime TranscationDate = DateTime.Now;
        string vendorname;

        
        

        public void fillArray()
        {
            int randomNumber;
            Random rng = new Random();
            randomNumber = rng.Next(0, 25);
            AllTransactions.Add(randomNumber);
            
        }

        public void ViewTransactions()
        {
            foreach (int item in AllTransactions)
            {
                AllTransactions.ForEach(Console.WriteLine);
                
            }
        }
     


    }

}
