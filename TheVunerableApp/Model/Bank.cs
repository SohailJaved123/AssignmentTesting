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
    internal class Bank
    {
        const String nameOfTheBank = "TheVulnerableBank";

        public List<Account> accountRoster { get; private set; }
    }
}
