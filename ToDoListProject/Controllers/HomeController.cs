using Microsoft.AspNetCore.Mvc;
using ToDoListProject.Models;

namespace ToDoListProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
