using Microsoft.AspNetCore.Mvc;

namespace ProjetoBestProject.Presentation.Mvc
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
