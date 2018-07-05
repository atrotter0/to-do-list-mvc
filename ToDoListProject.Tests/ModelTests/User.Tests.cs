using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoListProject.Models;

namespace ToDoListProject.Tests
{
    [TestClass]
    public class UserTest : IDisposable
    {
        public void Dispose()
        {
            User.ClearAll();
        }

        [TestMethod]
        public void GetSetUsername_GetsSetsUsername_String()
        {
            User newUser = new User();
            newUser.SetUsername("Bob");
            Assert.AreEqual("Bob", newUser.GetUsername());
        }

        [TestMethod]
        public void GetSetEmail_GetsSetsEmail_String()
        {
            User newUser = new User();
            newUser.SetEmail("bob@test.com");
            Assert.AreEqual("bob@test.com", newUser.GetEmail());
        }

        [TestMethod]
        public void GetSetFullName_GetsSetsFullName_String()
        {
            User newUser = new User();
            newUser.SetFullName("Bob Barker");
            Assert.AreEqual("Bob Barker", newUser.GetFullName());
        }

        [TestMethod]
        public void GetSetPassword_GetsSetsPassword_String()
        {
            User newUser = new User();
            newUser.SetPassword("password");
            Assert.AreEqual("password", newUser.GetPassword());
        }

        [TestMethod]
        public void GetAll_GetsAllInstancesOfUser_List()
        {
            User newUser1 = new User();
            User newUser2 = new User();
            User newUser3 = new User();
            List<User> userList = new List<User> { newUser1, newUser2, newUser3 };
            CollectionAssert.AreEqual(userList, User.GetAll());
        }

        [TestMethod]
        public void ClearAll_ClearsAllInstancesOfUser_Int()
        {
            User newUser1 = new User();
            User newUser2 = new User();
            User newUser3 = new User();
            User.ClearAll();
            List<User> emptyList = new List<User>() {};
            CollectionAssert.AreEqual(emptyList, User.GetAll());
        }

        [TestMethod]
        public void Find_FindsUserById_User()
        {
            User newUser = new User();
            Assert.AreEqual(newUser, User.Find(1));
        }
    }
}
