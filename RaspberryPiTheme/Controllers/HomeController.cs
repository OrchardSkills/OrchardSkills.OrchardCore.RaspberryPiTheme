using Microsoft.AspNetCore.Mvc;

namespace OrchardCore.RaspberryPiTheme.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
