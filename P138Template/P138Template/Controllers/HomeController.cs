using Microsoft.AspNetCore.Mvc;

namespace P138Template.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
