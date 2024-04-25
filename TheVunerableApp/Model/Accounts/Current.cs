

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
