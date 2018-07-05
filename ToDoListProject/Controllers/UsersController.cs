using Microsoft.AspNetCore.Mvc;
using ToDoListProject.Models;

namespace ToDoListProject.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("/users")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/users/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/users")]
        public ActionResult Create(string username, string email, string fullName, string password)
        {
            // User newUser = new User();
            // List<User> allUsers = User.GetAll();
            //return View("Users", allUsers);
            return View();
        }
    }
}