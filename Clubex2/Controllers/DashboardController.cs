using Microsoft.AspNetCore.Mvc;

namespace Clubex2.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
