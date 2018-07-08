using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoListProject.Models;

namespace ToDoListProject.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet("/items")]
        public ActionResult Index()
        {   
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        // [HttpGet("/items/new")]
        // public ActionResult CreateForm()
        // {
        //     return View();
        // }

        // [HttpPost("/items")]
        // public ActionResult Create(int id, string description)
        // {
        //     Item newItem = new Item(id, description);
        //     List<Item> allItems = Item.GetAll();
        //     return View("Index", allItems);
        // }
    }
}