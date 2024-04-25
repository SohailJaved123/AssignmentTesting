/*
 This Code is built in C# Language. It is a bank application
 You can open this application in Microsoft Visual Studio 2022.
 
 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheVunerableApp.DataSource
{
    internal class DBAdapter
    { 
        static void ConnectToRemoteDB()
        {
            string server = "Nebuchadnezzar";
            string database = "TheBankOfZion";
            string username = "Morpheus";
            string password = "iL00k4N30";

            string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Connected to MySQL server!");

                        // We arent using the Remote DB here; however, this is a valid code in the App

                        connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("Failed to connect to MySQL server.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

}
