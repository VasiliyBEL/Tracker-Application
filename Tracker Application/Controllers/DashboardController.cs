using Microsoft.AspNetCore.Mvc;

namespace Tracker_Application.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
