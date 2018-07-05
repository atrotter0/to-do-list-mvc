using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoListProject.Models;

namespace ToDoListProject.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet("/accounts")]
        public ActionResult Index()
        {   
            List<Account> allAccounts = Account.GetAll();
            return View(allAccounts);
        }

        [HttpGet("/accounts/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/accounts")]
        public ActionResult Create(string username, string email, string fullName, string password)
        {
            Account newAccount = new Account(username, email, fullName, password);
            List<Account> allAccounts = Account.GetAll();
            return View("Index", allAccounts);
        }
    }
}