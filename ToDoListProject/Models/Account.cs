using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ToDoListProject;

namespace ToDoListProject.Models
{
    public class Account
    {
        private string _username;
        private string _email;
        private string _fullName;
        private string _password; //encrypt this
        private int _id;

        public Account(string username, string email, string fullName, string password, int id = 0)
        {
            _id = id;
            _username = username;
            _email = email;
            _fullName = fullName;
            _password = password;
        }

        public void SetUsername(string username)
        {
            _username = username;
        }

        public string GetUsername()
        {
            return _username;
        }

        public void SetEmail(string email)
        {
            _email = email.ToLower();
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetFullName(string fullName)
        {
            _fullName = fullName;
        }

        public string GetFullName()
        {
            return _fullName;
        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        public string GetPassword()
        {
            return _password;
        }

        public int GetId()
        {
            return _id;
        }

        public static List<Account> GetAll()
        {
            List<Account> allAccounts = new List<Account> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM accounts;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
                string accountUsername = rdr.GetString(0);
                string accountEmail = rdr.GetString(1);
                string accountFullname = rdr.GetString(2);
                string accountPassword = rdr.GetString(3);
                int accountId = rdr.GetInt32(4);
                Account newAccount = new Account(accountUsername, accountEmail, accountFullname, accountPassword, accountId);
                allAccounts.Add(newAccount);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allAccounts;
        }
    }
}
