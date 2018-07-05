using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ToDoListProject.Controllers;
using ToDoListProject.Models;

namespace ToDoListProject.Tests
{
    [TestClass]
    public class UserControllerTest : IDisposable
    {
        public void Dispose()
        {
            User.ClearAll();
        }

        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            UserController controller = new UserController();
            ActionResult Index = controller.Index();
            Assert.IsInstanceOfType(Index, typeof(ViewResult));
        }

        [TestMethod]
        public void CreateForm_ReturnsCorrectView_True()
        {
            UserController controller = new UserController();
            ActionResult CreateForm = controller.CreateForm();
            Assert.IsInstanceOfType(CreateForm, typeof(ViewResult));
        }
    }
}
