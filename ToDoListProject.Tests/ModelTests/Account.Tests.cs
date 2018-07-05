using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoListProject.Models;

namespace ToDoListProject.Tests
{
    [TestClass]
    public class AccountTest : IDisposable
    {
        public void Dispose()
        {
            Account.ClearAll();
        }

        [TestMethod]
        public void GetSetUsername_GetsSetsUsername_String()
        {
            Account newAccount = new Account();
            newAccount.SetUsername("Bob");
            Assert.AreEqual("Bob", newAccount.GetUsername());
        }

        [TestMethod]
        public void GetSetEmail_GetsSetsEmail_String()
        {
            Account newAccount = new Account();
            newAccount.SetEmail("bob@test.com");
            Assert.AreEqual("bob@test.com", newAccount.GetEmail());
        }

        [TestMethod]
        public void GetSetFullName_GetsSetsFullName_String()
        {
            Account newAccount = new Account();
            newAccount.SetFullName("Bob Barker");
            Assert.AreEqual("Bob Barker", newAccount.GetFullName());
        }

        [TestMethod]
        public void GetSetPassword_GetsSetsPassword_String()
        {
            Account newAccount = new Account();
            newAccount.SetPassword("password");
            Assert.AreEqual("password", newAccount.GetPassword());
        }

        [TestMethod]
        public void GetAll_GetsAllInstancesOfAccount_List()
        {
            Account newAccount1 = new Account();
            Account newAccount2 = new Account();
            Account newAccount3 = new Account();
            List<Account> AccountList = new List<Account> { newAccount1, newAccount2, newAccount3 };
            CollectionAssert.AreEqual(AccountList, Account.GetAll());
        }

        [TestMethod]
        public void ClearAll_ClearsAllInstancesOfAccount_Int()
        {
            Account newAccount1 = new Account();
            Account newAccount2 = new Account();
            Account newAccount3 = new Account();
            Account.ClearAll();
            List<Account> emptyList = new List<Account>() {};
            CollectionAssert.AreEqual(emptyList, Account.GetAll());
        }

        [TestMethod]
        public void Find_FindsAccountById_Account()
        {
            Account newAccount = new Account();
            Assert.AreEqual(newAccount, Account.Find(1));
        }
    }
}
