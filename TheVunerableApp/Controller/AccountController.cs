/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */



using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheVunerableApp.DataSource;
using TheVunerableApp.Model;

namespace TheVunerableApp.Controller
{
    public static class AccountController
    {
        /*Author: Sohail Bagri
        Description: This function tests if the saving or current account is created using proper credentials or not
        */


        /*
        @Test
        function CreateSavingAccount("1","1.5","500.0")
        */
        public static Account CreateSavingsAccount(String customerId, double interestRate, double balance)
        {
            Savings savings = new Savings(balance, interestRate, customerId);
            SQLiteDB db = new SQLiteDB();
            db.CreateAccountInDB(savings, 1);
            return null;
        }
        /*@Test
         function CreateSavingAccount("2","5","1000.0")
         */
        public static Account CreateCurrentAccount(string customerId, double initBalance, double minBalance, double fee)
        {
            Current current = new Current(initBalance,minBalance,fee,customerId);
            SQLiteDB db = new SQLiteDB();
            db.CreateAccountInDB(current, 0);
            return null;
        }

        public static string CloseAccount(string customerId, string accountNumber) 
        { 
            SQLiteDB db = new SQLiteDB();
            db.CloseAccount(accountNumber);
            accountNumber = null; 
            return accountNumber; 
        }
        /*
        Author: Wasiq 
        Description: This function tests if the Customer Details are found or not.
        */


        /*
        @Test
        function SearchAccountByCustomer("1")
        */
        public static List<string> SearchAccountByCustomer(string customerId) 
        {
            SQLiteDB db = new SQLiteDB();
           return db.GetAllAccountsFromDB(customerId);
        }
        /*
        Author: Wasiq 
        Description: This function tests if the Customer Details are found or not.
        */
        /*
        @Test
        function AddCustomerToAnAccount("2554","1")
        */
        public static void AddCustomerToAnAccount(string accountNumber, string customerId) 
        { 
            SQLiteDB db = new SQLiteDB();
            db.AddCustomerToAnAccount(accountNumber, customerId);
        }
        

        public static double GetAccountBalance(string accountNumber)
        {
            SQLiteDB dB = new SQLiteDB();
            return dB.GetBalance(accountNumber);
        }

    }
}
