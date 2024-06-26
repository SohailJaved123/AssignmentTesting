﻿/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TheVunerableApp.Model;

namespace TheVunerableApp.DataSource
{
    internal class LocalStore
    { 
        public LocalStore()
        {
            FilePath = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["TRPath"];
        }
    
        public string FilePath { get; }

        public bool StoreTransactions(Transaction transaction)
        {
            string transactionInJson = JsonSerializer.Serialize(transaction);
            string path = transaction.TransactionId + ".json";
            File.WriteAllText(Path.Combine(FilePath,path),transactionInJson);
            return true;
        }

        public Transaction LoadTransaction(string path)
        {
           return JsonSerializer.Deserialize<Transaction>(path);
        }
    }
}
