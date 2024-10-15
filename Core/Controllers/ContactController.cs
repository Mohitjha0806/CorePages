using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            string num = "9584453705";
            return View("Contact", num);
        }

        public IActionResult Blog()
        {
            return View();
        }


    }
}
