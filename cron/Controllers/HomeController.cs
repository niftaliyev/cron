using Microsoft.AspNetCore.Mvc;

namespace cron.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
