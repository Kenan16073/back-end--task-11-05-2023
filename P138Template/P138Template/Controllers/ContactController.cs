using Microsoft.AspNetCore.Mvc;

namespace P138Template.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
