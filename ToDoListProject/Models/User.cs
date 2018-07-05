using System;
using System.Collections.Generic;

namespace ToDoListProject.Models
{
    public class User
    {
        private string _username;
        private string _email;
        private string _fullName;
        private string _password; //encrypt this
        private int _id;
        private static List<User> _instances = new List<User> {};

        public User(string username, string email, string fullName, string password)
        {
            _username = username;
            _email = email;
            _fullName = fullName;
            _password = password;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public User()
        {
            _instances.Add(this);
            _id = _instances.Count;
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

        public static List<User> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static User Find(int searchId)
        {
           return _instances[searchId-1];
        }
    }
}
