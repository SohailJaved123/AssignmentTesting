

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVunerableApp.Model
{
    internal class Bank
    {
        const String nameOfTheBank = "TheVulnerableBank";

        public List<Account> accountRoster { get; private set; }
    }
}
