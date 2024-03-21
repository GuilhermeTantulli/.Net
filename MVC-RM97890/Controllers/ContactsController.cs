using Microsoft.AspNetCore.Mvc;
using MVC_RM97890.Models;

namespace MVC_RM97890.Controllers
{
    public class ContactsController : Controller
    {
        private User user = new User();
        public IActionResult Contacts()
        {
            ViewBag.User = user;
            return View();
        }
    }
}
