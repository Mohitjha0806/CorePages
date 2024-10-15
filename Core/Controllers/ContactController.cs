using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }
    }
}
