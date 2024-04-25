

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVunerableApp.Model
{
    public class User
    {
        public User(string govId, string name, string sirName, string email, string password)
        {
            GovId = govId;
            Name = name;
            SirName = sirName;
            Email = email;
            Password = password;
        }

        public string GovId { get; set; }
        public string Name { get; set; }
        public string SirName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
