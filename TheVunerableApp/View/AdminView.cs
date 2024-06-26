﻿/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheVunerableApp.Controller;

namespace TheVunerableApp.View
{
    public static class AdminView
    {
        public static void CreateUser()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("1. Create Admin");
            Console.WriteLine("2. Create Customer");
            Console.WriteLine("X. eXit");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please enter your option");

            string option = Console.ReadLine();

            Console.WriteLine("Please enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the sir name");
            string sName = Console.ReadLine();
            Console.WriteLine("Please enter the government provided identification number");
            string id = Console.ReadLine();
            Console.WriteLine("Please enter your first time password");
            string password = Console.ReadLine();
            Console.WriteLine("Please enter your email address");
            string email = Console.ReadLine();

            string userId = ""; 

            switch (option)
            {
                case "1":
                    userId = UserController.CreateUser(UserType.Admin, id, name, sName, email, password, DateTime.Now, Model.Position.representative, Model.Role.Admin, "Sandy Bay", "SB");
                    break;

                case "2":
                    userId = UserController.CreateUser(UserType.Customer, id, name, sName, email, password, DateTime.Now, Model.Position.none, Model.Role.none, "Sandy Bay", "SB");
                    break;

            }

            Console.WriteLine("User created successfully with id:{0}", userId);
        } 
    }


}
