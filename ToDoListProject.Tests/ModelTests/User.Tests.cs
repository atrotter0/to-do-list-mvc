using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoListProject.Models;

namespace ToDoListProject.Tests
{
    [TestClass]
    public class UserTest
    {
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
    }
}
