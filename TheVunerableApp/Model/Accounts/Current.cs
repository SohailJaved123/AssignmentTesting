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
    internal class Current : Account
    {
        public Current(double initialBalance, double minimumBalance, double monthlyFee, string customerId) : base(initialBalance, customerId)
        {
            base.Balance = initialBalance;
            base.AddCustomer(customerId);
            MinimumBalance = minimumBalance;
            MonthlyFee = monthlyFee;
        }

        public double MinimumBalance { get; set; }

        public double MonthlyFee { get; set; }

    }
}
