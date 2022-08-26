using Microsoft.AspNetCore.Mvc;
using WebApp_1.Models;

namespace WebApp_1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        { 
            User user = new User();
            user.Name = "Jagger";
            user.Email = "jagger@gmail.com";
            return View(user);
        }

        [HttpPost]
        public IActionResult Index(string id, string name, string email) 
        {
            User user = new User();
            user.Name = "Jagger";
            user.Email = "jagger@gmail.com";
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Email = email;
            return View(user);
        }
    }
}
