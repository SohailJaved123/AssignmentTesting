﻿/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */

using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TheVunerableApp.DataSource;
using TheVunerableApp.Model;

namespace TheVunerableApp.Controller
{
    public static class UserController
    {

        /*Author: Vinod
        Description: This function tests if the user is created
        */


        /*
        @Test
        function CreateUser(UserType.Customer, "321-456-9876", "Jean", "Grey", "j.grey@xmen.com", "iReadMind1978", DateTime.Parse("27/07/2019"), Model.Position.none, Model.Role.none, "Sandy Bay", "SB19")
        */
        public static string CreateUser(UserType type, string govId, string name, string sName, string email, string password, DateTime startDate, Position position, Role role, string branchName, string branchId)
        {
            SQLiteDB sql = new SQLiteDB(); 
            if (type == UserType.Admin) // Admin
            {
                Admin admin = new Admin(govId, name, sName, email, password, startDate, position, role, branchName, branchId);
                sql.CreateUserInDB(admin, 1);
                return admin.AdminId;
            }
            // else a Customer
            Customer customer = new Customer(govId, name, sName, email, password);
            sql.CreateUserInDB(customer, 0);
            return customer.CustomerId;
        }
        public static List<string> ListOfAccountBalance(string customerId)
        {
            // get the number of account
            SQLiteDB db = new SQLiteDB();
            List<string> accountNumbers = db.GetAllAccountsFromDB(customerId);
            List<string> balances = new List<string>();

            for (int i = 0; i<=accountNumbers.Count; i++)
            {
                balances[i] = accountNumbers[i] +"-"+ db.GetBalance(accountNumbers[i]);
            }
            return balances;
        }
        public static void UpdateUser(string customerId, string name, string sName, string email, string govId)
        {
            SQLiteDB sql = new SQLiteDB();
            sql.UpdateCustomerDetailsInDB(customerId, name, sName, email, govId);
        }

        public static Customer DisplayUserDetails(string customerId)
        {
            SQLiteDB sql = new SQLiteDB();
            return sql.GetCustomerDetailsFromDB(customerId);
        }
        public static string RemoveCustomer(string customerId)
        {
            SQLiteDB sql = new SQLiteDB();
            Customer customer = sql.RemoveUser(customerId);
            return customer.CustomerId; // return the customer id of the user removed from the database
        }
        public static List<Customer> SearchCustomerByAccountNumber(string  accountNumber)
        {
            SQLiteDB sql = new SQLiteDB();
            List<Customer> customerList = new List<Customer>();

            List<string> customerIds = sql.GetCustomerIdFromDB(accountNumber);
            for (int i = 0; i <= customerIds.Count; i++)
            {
                customerList.Add(sql.GetCustomerDetailsFromDB(customerIds[i]));
            }
            return customerList;
        }
    }

    public enum UserType { Customer, Admin}
}
