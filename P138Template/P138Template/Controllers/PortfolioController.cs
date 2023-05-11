using Microsoft.AspNetCore.Mvc;

namespace P138Template.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
