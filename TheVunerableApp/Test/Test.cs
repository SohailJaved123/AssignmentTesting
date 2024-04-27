/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheVunerableApp.Controller;

namespace TheVunerableApp.Test
{
    internal class TestCase { 
    public static void Sohail_Testing1()
    {
            AccountController.CreateCurrentAccount("2", 5, 1000.0,2.5);
    }
    public static void Sohail_Testing2()
    {
            AccountController.CreateSavingsAccount("1", 1.5, 500.0);
    }
    public static void Wasiq_Testing1()
    {
            AccountController.AddCustomerToAnAccount("1", "2");
    }
    public static void Wasiq_Testing2()
    {
            AccountController.SearchAccountByCustomer("1");
    }
    public static void Vinod_Testing1() 
    {
            //UserController.CreateUser(UserType.Customer, "321-456-9876", "Jean", "Grey", "j.grey@xmen.com", "iReadMind1978", DateTime.Parse("27/07/2019"), Model.Position.none, Model.Role.none, "Sandy Bay", "SB19");
            UserController.CreateUser(UserType.Customer, "321-456-9876", "Jean", "Grey", "j.grey@xmen.com", "iReadMind1978", DateTime.Parse("2019-07-27"), Model.Position.attendent, Model.Role.Admin, "Sandy Bay", "SB19");
    }
    public static void Vinod_Testing2()
    {
            UserController.ListOfAccountBalance("1");    
    }






    }

}
