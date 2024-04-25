/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVunerableApp.Model
{
    internal class Transaction
    {
        public string TransactionId { get; private set; }
        public string TransactionDate { get; private set; }
        public string SourceAccount { get; private set; }
        public string TargetAccount { get; private set; }

        public double Amount { get; private set; }
        
        public Transaction(string sourceAccount, double amount, string targetAccount)
        {
            TransactionId = getTransactionId(10);
            TransactionDate = DateTime.Now.ToString();
            SourceAccount = sourceAccount;
            TargetAccount = targetAccount;
            Amount = amount;
        }

        private string getTransactionId(int max)
        {
            Random random = new Random();
            string id = "";

            for (int i = 0; i < max; i++)
            {
               id += random.Next(10).ToString();
            }
            
            return id;
        }
    }
}
