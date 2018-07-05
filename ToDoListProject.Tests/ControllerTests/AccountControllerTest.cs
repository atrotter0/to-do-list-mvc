using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ToDoListProject.Controllers;
using ToDoListProject.Models;

namespace ToDoListProject.Tests
{
    [TestClass]
    public class AccountControllerTest : IDisposable
    {
        public void Dispose()
        {
            Account.ClearAll();
        }

        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            AccountController controller = new AccountController();
            ActionResult Index = controller.Index();
            Assert.IsInstanceOfType(Index, typeof(ViewResult));
        }

        [TestMethod]
        public void Index_HasCorrectModelType_Account()
        {
            ViewResult Index = new AccountController().Index() as ViewResult;
            var result = Index.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(List<Account>));
        }

        [TestMethod]
        public void CreateForm_ReturnsCorrectView_True()
        {
            AccountController controller = new AccountController();
            ActionResult CreateForm = controller.CreateForm();
            Assert.IsInstanceOfType(CreateForm, typeof(ViewResult));
        }

        [TestMethod]
        public void Create_HasCorrectModelType_Account()
        {
            ViewResult Create = new AccountController().Create("Hobbit0", "frodo@shire.com", "Frodo Baggins", "123") as ViewResult;
            var result = Create.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(List<Account>));
        }
    }
}
