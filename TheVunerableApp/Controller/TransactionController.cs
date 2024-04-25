/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheVunerableApp.DataSource;
using TheVunerableApp.Model;

namespace TheVunerableApp.Controller
{
    public static class TransactionController
    {
        public static string getTRPath()
        {
            LocalStore store = new LocalStore();
            return store.FilePath;
        }

        public static string StoreTransactions(string sAccount, double amount, string tAccount)
        {
            LocalStore store = new LocalStore();
            Transaction transaction = new Transaction(sAccount, amount, tAccount);
            store.StoreTransactions(transaction);

            SQLiteDB db = new SQLiteDB();
            db.StoreTransaction(transaction);

            return transaction.TransactionId;
        }

        public static void LoadTransaction(string path)
        {
            LocalStore store = new LocalStore();

        }
    }
}
