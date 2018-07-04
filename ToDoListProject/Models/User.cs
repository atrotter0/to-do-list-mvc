using System;
using System.Collections.Generic;

namespace ToDoListProject.Models
{
    public class User
    {
        private string _username;
        private string _email;
        private string _fullName;
        private string _password;

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
    }
}
